using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;
using System.ServiceModel;
using System.Windows.Forms;

namespace MoneyServerHost
{
    /// <summary>
    /// MoneyPotService
    /// Implements the IMoneyPotService 
    /// Service for the Money Pot
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    public class MoneyPotService : IMoneyPotService
    {
        #region Fields

        // Object Locks for Concurrency
        private static object m_StaticLock = new object();
        private object m_InstanceLock = new object();

        // Limits on the Client Withdrawls
        private const decimal staticLimit = 10M;
        private const decimal instanceLimit = 1M;

        // 1 million dollars in the Static Money Pot (Starting)
        private static decimal m_StaticMoneyPot = 100000M;
        // 1 thousand dollars in the Instance Money Pot (Starting)
        private decimal m_InstanceMoneyPot = 1000M;

        // Form Objects
        private static Main frmMain;

        #endregion Fields

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frmMain = new Main());
        }

        #region Service Implementation

        /// <summary>
        /// GetMoneyInstance
        /// Returns an amount of money from the instance resource
        /// money pot
        /// </summary>
        /// <param name="clientID">the client identifer (int)</param>
        /// <returns>an amount of money (decimal) from the resources</returns>
        public decimal GetMoneyInstance(int clientID)
        {
            // Update the Event Log GUI
            frmMain.UpdateEventList($"Instance -> Client {clientID} calling the Instance Money Pot");

            // Locks for Concurrency of the Instance Money Resource
            lock (m_InstanceLock)
            {
                System.Threading.Thread.Sleep(1000);

                // If there is less money left in the pot than the withdrawl amount
                if (m_InstanceMoneyPot - instanceLimit < 0)
                {
                    decimal remainder = m_InstanceMoneyPot;
                    m_InstanceMoneyPot = 0M;

                    // Update the Instance Money Pot GUI
                    frmMain.UpdateInstanceMoneyPot(m_InstanceMoneyPot);

                    // Update the Event Log GUI
                    frmMain.UpdateEventList($"Instance -> Sending {remainder:C} to client {clientID}");

                    return remainder;
                }

                // Plenty of Money left!
                else
                {
                    m_InstanceMoneyPot -= instanceLimit;

                    // Update the Instance Money Pot GUI
                    frmMain.UpdateInstanceMoneyPot(m_InstanceMoneyPot);

                    // Update the Event Log GUI
                    frmMain.UpdateEventList($"Instance -> Sending {instanceLimit:C} to client {clientID}");

                    return instanceLimit;

                } // end of else

            } // end of lock
        } // end of method

        /// <summary>
        /// GetMoneyStatic
        /// Returns an amount of money from the static resource
        /// Money Pot
        /// </summary>
        /// <param name="clientID">the client identifer (int)</param>
        /// <returns>an amount of money (decimal) from the resources</returns>
        public decimal GetMoneyStatic(int clientID)
        {
            // Update the Event Log GUI
            frmMain.UpdateEventList($"Static -> Client {clientID} calling the Money Pot");

            // Locks for Concurrency of the Static Money Resource
            lock (m_StaticLock)
            {
                System.Threading.Thread.Sleep(1000);
                
                // If there is less money left in the pot than the withdrawl amount
                if(m_StaticMoneyPot - staticLimit < 0)
                {
                    decimal remainder = m_StaticMoneyPot;
                    m_StaticMoneyPot = 0M;

                    // Update the Static Money Pot GUI
                    frmMain.UpdateStaticMoneyPot(m_StaticMoneyPot);

                    // Update the Event Log GUI
                    frmMain.UpdateEventList($"Static -> Sending {remainder:C} to client {clientID}");

                    return remainder;
                }

                // Plenty of Money left!
                else
                {
                    m_StaticMoneyPot -= staticLimit;

                    // Update the Static Money Pot GUI
                    frmMain.UpdateStaticMoneyPot(m_StaticMoneyPot);

                    // Update the Event Log GUI
                    frmMain.UpdateEventList($"Static -> Sending {staticLimit:C} to client {clientID}");

                    return staticLimit;

                } // end of else
            } // end of lock

        } // end of method

        #endregion Service Implementation

    } // end of class
} // end of namespace
