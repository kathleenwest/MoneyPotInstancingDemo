using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.Diagnostics;
using System.Timers;
using System.Threading;

namespace Client
{
    public partial class Client : Form
    {
        #region Fields

        // Monitoring for Cancellation
        CancellationTokenSource m_TokenSource = null;

        // Stop watch for the form
        private System.Timers.Timer myTimer;

        // Constant Run-Time for Client
        private const int runTime = 10;

        #endregion Fields

        #region Properties

        // Time Elpased in Seconds
        private int TimeElapsedSeconds { get; set; }
        
        // Total Money Pot Value Received from Static Server Call
        private decimal StaticMoneyPotTotal { get; set; }

        // Total Money Pot Value Received from Instance Server Call
        private decimal InstanceMoneyPotTotal { get; set; }

        // Client ID 
        private int ClientID { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public Client()
        {

            InitializeComponent();

            // Initialize the Timer
            this.myTimer = new System.Timers.Timer();
            // 60 seconds it will file after start
            myTimer.Interval = 1000;

            // Hook up the Elapsed event for the timer. 
            myTimer.Elapsed += OnTimedEvent;

            // Have it Reset
            myTimer.AutoReset = true;

            // Initialize my GUI
            lblCountDown.Text = $"{runTime} seconds run time";
            btnStart.Enabled = true;
            btnCancel.Enabled = false;

        } // end of method

        #endregion Constructors

        #region Events

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Try Parse the User Input
            int clientID = default(int);

            // Validate Client ID
            if (!int.TryParse(txtClientID.Text, out clientID))
            {
                MessageBox.Show("Enter a Valid Client ID Number.", "Invalid Input", MessageBoxButtons.OK);
                return;
            }

            // Set the Client ID
            ClientID = clientID;

            // Update the GUI 
            btnStart.Enabled = false;
            btnCancel.Enabled = true;
            lblCountDown.Text = $"{runTime} seconds left";

            // Reset Time Elapsed
            TimeElapsedSeconds = 0;

            // Enable the Timer
            myTimer.Enabled = true;

            // set the CancelationTokenSource object to a new instance
            m_TokenSource = new CancellationTokenSource();

            // When Tasks complete, TPL provides a mechanism to automatically 
            // continue execution on a WinForm or WPF UI thread.To do this 
            // we need a handle to the UI thread which we’ll use later
            TaskScheduler ui = TaskScheduler.FromCurrentSynchronizationContext();

            // start the Task, passing it the name of the method that 
            // will be the entry point for the Task and the token used for cancellation:
            Task myServiceCallTask = Task.Factory.StartNew(CallService, m_TokenSource.Token);

            // first continuation call will execute only when the Task completes successfully
            // notifies the user by showing a message box then resetting the buttons to their 
            // default configuration. Notice that the last parameter to ContinueWith is “ui”. 
            // This tells ContinueWith to execute the lambda statements to execute within 
            // the context of the UI thread.No Invoke / BeginInvoke needed here.
            Task resultOK = myServiceCallTask.ContinueWith(resultTask =>
            {
                //MessageBox.Show("Completed Service Call Test", "Task Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnStart.Enabled = true;
                btnCancel.Enabled = false;
            }, CancellationToken.None, TaskContinuationOptions.OnlyOnRanToCompletion, ui);

            // second continuation call only executes if the task is  cancelled
            Task resultCancel = myServiceCallTask.ContinueWith(resultTask =>
            {
                //MessageBox.Show("Service Call Stopped by User", "Task Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnStart.Enabled = true;
                btnCancel.Enabled = false;
                lblCountDown.Text = "Cancelled";
                // Send a Message
                //MessageBox.Show("Cancelled by User", "Cancelled", MessageBoxButtons.OK);
            }, CancellationToken.None, TaskContinuationOptions.OnlyOnCanceled, ui);

        } // end of method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            // Increment Time Elapsed
            TimeElapsedSeconds++;

            // Calculate Time Remaining
            int timeRemaining = runTime - TimeElapsedSeconds;

            // Update the GUI
            if (timeRemaining > 0)
            {
                // Update the UI Thread GUI
                UpdateLabelText(lblCountDown, $"{timeRemaining} seconds left");
            }
            else
            {
                // Stop Timer
                myTimer.Stop();

                // Disable the Time
                myTimer.Enabled = false;

                // Update the UI Thread GUI
                UpdateLabelText(lblCountDown, $"{timeRemaining} seconds left");
            }
        } // end of method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {

            // if a valid token source is available then signal 
            // to any listeners that the Task has been cancelled
            if (m_TokenSource != null)
            {
                // Send Cancel to Token
                m_TokenSource.Cancel();

                // Stop Timer
                myTimer.Stop();
                myTimer.Enabled = false;

                // Update the UI Thread GUI
                UpdateLabelText(lblCountDown, $"Cancelled.");

            } // end of if

        } // end of method

        #endregion Events

        #region Methods

        /// <summary>
        /// CallService
        /// Creates a ChannelFactory proxy to the service
        /// Starts the Timer
        /// Listens for Cancellation Event from user clicking cancel
        /// Called from the Async Task from the UI Thread
        /// Get resources from the service (when connected)
        /// </summary>
        private void CallService()
        {
            try
            {
                // Make a ChannelFactory Proxy to the Service
                using (ChannelFactory<IMoneyPotService> cf = new ChannelFactory<IMoneyPotService>("BasicHttpBinding_IMoneyPotService"))
                {
                    cf.Open();
                    IMoneyPotService proxy = cf.CreateChannel();

                    if (proxy != null)
                    {
                        // Start the Count Down
                        myTimer.Start();

                        // While the Timer is Running
                        while (myTimer.Enabled)
                        {
                            // Call ThrowIfCancellationRequested periodically to test for cancellation request 
                            // At every iteration we will check to see if cancellation was requested
                            // if (m_TokenSource.Token.IsCancellationRequested) throw new OperationCanceledException();
                            m_TokenSource.Token.ThrowIfCancellationRequested();
        
                            try
                            {
                                // Call the Static Money Pot Service
                                StaticMoneyPotTotal += proxy.GetMoneyStatic(ClientID);

                                // Call the Instance Money Pot Service
                                InstanceMoneyPotTotal += proxy.GetMoneyInstance(ClientID);

                                // Update the GUI on the UI Thread
                                UpdateLabelText(lblStaticMoneyTotal, $"{StaticMoneyPotTotal:C}");
                                UpdateLabelText(lblInstanceMoneyTotal, $"{InstanceMoneyPotTotal:C}");
                            }

                            // when the user cancels the Task
                            catch (OperationCanceledException)
                            {
                                throw;

                            } // end of catch

                            catch (Exception ex)
                            {
                                // Cancel the Task
                                btnCancel_Click(this, null);

                                // Update the Text
                                UpdateLabelText(lblCountDown, $"Cannot Connect to Server");

                                // Add to Debug
                                Debug.WriteLine("Cannot Connect to Server");
                                Debug.WriteLine(ex.Message);
                            }
                           
                        } // end of while loop

                    }
                    else
                    {
                        // Cannot Connect to Server 
                        MessageBox.Show("Cannot Create a Channel to a Proxy. Check Your Configuration Settings.", "Proxy", MessageBoxButtons.OK);
                        return;
                    }
                } // end of using

            } // end of try

            // when the user cancels the Task
            catch (OperationCanceledException)
            {
                throw;

            } // end of catch

        } // end of method

        /// <summary>
        /// Update a Text Label on GUI
        /// Update a value on the UI thread from within our task
        /// </summary>
        /// <param name="label">the label control (Label) to update</param>
        /// <param name="message">the message (string) to be changed on the label text</param>
        private void UpdateLabelText(Label label, string message)
        {
            // check if cross-thread synchronization is required
            // check the specific control’s InvokeRequired property
            // So, if this method is called from our task, the 
            // test for InvokeRequired required will return
            // true. This will then asynchronously call this method
            // recursively. This time, however, since it was invoked upon 
            // the UI thread, InvokeRequired will be false so the else 
            // portion of the function executes, updating the Label.
            if (label.InvokeRequired)
            {
                // If this condition is true, then we need to recursively 
                // invoke this method on the UI thread
                label.BeginInvoke(new Action<Label, string>(UpdateLabelText), label, message);
            } // end of if

            // simply update the text box with the value given in the method
            else
            {
                label.Text = message;
            } // end of else

        } // end of method

        #endregion Methods

    } // end of class

} // end of namespace
