using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cards
{
    /// <summary>
    /// Main menu form.
    /// </summary>
    public partial class MainMenu : Form
    {
        #region Fields
        private BlackJack bj;
        private VirtualCasinoLogin vcl;
        private Roulette r;
        public User user;
        private MainMenuLog log;
        public bool loggedIn;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes Main Form and other objects.
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            BlankSlateProtocol();
            this.log = new MainMenuLog();
            log.LogOpen();
        }
        #endregion

        #region Events
        /// <summary>
        /// Opens BlackJack.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void blackjack_Click(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                bj.User = user;
                bj.Show();
            }
        }

        /// <summary>
        /// Opens Roulette.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roulette_Click(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                r.User = user;
                r.Show();
            }
        }

        /// <summary>
        /// Runs the login process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {
                Login();
                loggedIn = true;
            }
            else
            {
                Save();
                BlankSlateProtocol();
                UpdateText();
            }
        }

        /// <summary>
        /// Views the log file for the current run time.
        /// </summary>
        /// <remarks>Only Admin account has access.</remarks>
        /// <param name="sender">Honestly IDK.</param>
        /// <param name="e">Couldn't tell you.</param>
        private void log_button_Click(object sender, EventArgs e)
        {
            // Only Admin account can access log file.
            if((loggedIn) && (user.AdminPrivileges))
            { 
                List<String> logFile = new List<String>();
                using (StreamReader sr = new StreamReader("Log.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        logFile.Add(line);
                }
                int index = 0;
                for (int i = logFile.Count() - 1; i >= 0; i--)
                {
                    if (logFile.ElementAt(i).Contains("Opened Main Menu.")
                        || logFile.ElementAt(i).Contains("View log file."))
                    {
                        index = i;
                        break;
                    }
                }
                log.LogViewLog();
                string tmp = "";
                for (int i = index; i < logFile.Count; i++)
                {
                    tmp += logFile.ElementAt(i) + "\n";
                }
                MessageBox.Show(tmp, "Current Runtime Log");
            }
        }

        /// <summary>
        /// Saves and Logs the end of the current run.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (loggedIn)
                this.Save();
            log.LogOpen();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Opens the Login Menu.
        /// </summary>
        private void Login()
        {
            vcl.Show();
        }

        /// <summary>
        /// Updates the Main Menu Text.
        /// </summary>
        public void UpdateText()
        {
            loginStatus.Text = user.Username;
            if(loggedIn) { login.Text = "Logout"; }
            else 
            {
                loginStatus.Text = "Sign in";
                login.Text = "Login"; 
            }
        }

        /// <summary>
        /// Saves the "active" User to the Accounts file.
        /// </summary>
        public void Save()
        {
            // Saves the "Active" user to the file (Not the guest "Player" account).
            if (!user.Username.Equals("Player"))
            {
                using (StreamWriter sw = File.AppendText("acc.txt"))
                    sw.WriteLine(user.WriteUser());
                log.LogSignOut(user.Username);
            }
        }

        /// <summary>
        /// Essentially the Constructor, Sets many values to their default state.
        /// </summary>
        public void BlankSlateProtocol()
        {
            loginStatus.Text = "Sign in";
            loggedIn = false;
            this.bj = new BlackJack();
            this.vcl = new VirtualCasinoLogin(this);
            this.r = new Roulette();
        }
        #endregion
    }
}
