using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MoneyServerHost
{
    /// <summary>
    /// Main Form for Server
    /// </summary>
    public partial class Main : Form
    {
        //  Service Host object for hosting the service
        ServiceHost host;

        /// <summary>
        /// Initializes the Main Form
        /// </summary>
        public Main()
        {
            InitializeComponent();

        }

        #region GUIUpdates

        /// <summary>
        /// UpdateStaticMoneyPot
        /// Updates the GUI text label of the current static money pot value
        /// </summary>
        /// <param name="MoneyPotStatic"> Current value (decimal) of the Static Money Pot</param>
        internal void UpdateStaticMoneyPot(decimal value)
        {         
            lblStaticFunds.Text = $"S:{value:C}";

        } // end of method

        /// <summary>
        /// UpdateInstanceMoneyPot
        /// Updates the GUI text label of the current instance money pot value
        /// </summary>
        /// <param name="value"> Current value (decimal) of the Instance Money Pot</param>
        internal void UpdateInstanceMoneyPot(decimal value)
        {
            lblInstanceFunds.Text = $"I:{value:C}";

        } // end of method

        /// <summary>
        /// UpdateEventList
        /// Updates the GUI List Box with the new event message 
        /// </summary>
        /// <param name="message">an event message (string)</param>
        internal void UpdateEventList(string message)
        {
            lstTransactions.Items.Insert(0, message);
        }

        #endregion GUIUpdates

        #region FormOnLoadClose

        /// <summary>
        /// Main_Load
        /// Instances a new ServiceHost object
        /// </summary>
        /// <param name="sender">not used</param>
        /// <param name="e">not used</param>
        private void Main_Load(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(MoneyPotService));
            host.Open();
        }

        /// <summary>
        /// Main_FormClosed
        /// Closes the ServiceHost object
        /// </summary>
        /// <param name="sender">not used</param>
        /// <param name="e">not used</param>
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            host.Close();
        }

        #endregion FormOnLoadClose

    } // end of class
} // end of namespace
