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
    /// A Class for the Login menu
    /// </summary>
    public partial class VirtualCasinoLogin : Form
    {
        #region Fields
        private string username;
        private string password;
        private bool loggedIn;
        private bool guestAccount;
        private List<User> accounts;
        private MainMenu vc;
        private SignInLog log;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructs the Login menu object.
        /// </summary>
        /// <param name="m">The MaineMenu Instance. Allows access to public variables of MainMenu.</param>
        public VirtualCasinoLogin(MainMenu m)
        {
            this.vc = m;
            InitializeComponent();
            this.loggedIn = false;
            this.guestAccount = false;
            this.username = "";
            this.password = "";
            this.accounts = new List<User>();
            this.log = new SignInLog();
            this.AcceptButton = guest;

            // Loads all accounts into the List.
            using (StreamReader sr = new StreamReader(MainMenu.ACCOUNT_FILE))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    accounts.Add(User.ReadUser(line));
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Updates the username field.
        /// </summary>
        /// <remarks>Spaces are ignored.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uname_TextChanged(object sender, EventArgs e)
        {
            username = uname.Text;

            // Spaces are completely ignored from username.
            username = username.Replace(" ", "");

            // Searches for the current username.
            bool taken = false;
            foreach (User u in accounts)
            {
                if (u.Username.Equals(username))
                    taken = true;
            }

            // Changes what the [ENTER] key will do.
            if(!taken) { this.AcceptButton = newAcct; }
            else { this.AcceptButton = confirmLogin; }
        }

        /// <summary>
        /// Updates the password field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pwd_TextChanged(object sender, EventArgs e)
        {
            password = pwd.Text;
        }

        /// <summary>
        /// Creates a new account with the current entered username and password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newAcct_Click(object sender, EventArgs e)
        {
            // Searches if Username is taken.
            bool validUName = true;
            foreach(User u in accounts)
            {
                if (u.Username.Equals(username))
                    validUName = false;
            }

            // Validates username and password length.
            if (validUName && (username.Length > 0 && password.Length > 0))
            {
                accounts.Add(new User(username, password));
                log.LogNewAccount(username);
                confirmLogin_Click(sender, e);
            }
            else if (username.Length == 0 || password.Length == 0)
                text1.Text = "Entries cannot be blank.";
            else
                text1.Text = "Username already taken.";
        }

        /// <summary>
        /// Signs in on the Guest account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guest_Click(object sender, EventArgs e)
        {
            guestAccount = true;
            loggedIn = true;
            log.LogGuest();
            this.Close();
        }

        /// <summary>
        /// Signs in the account of the username and password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmLogin_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (User u in accounts)
                {
                    if (u.Login(username, password))
                    {
                        loggedIn = true;
                        this.Close();
                        break;
                    }
                }
                if (!loggedIn)
                    text1.Text = "Invalid account details.";
            }
            catch(Exception)
            {
                text1.Text = "Internal Account Error.";
            }
        }

        /// <summary>
        /// Logs opening the Login menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VirtualCasinoLogin_Shown(object sender, EventArgs e)
        {
            log.LogOpen();
        }

        /// <summary>
        /// Executes the Login menu procedure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VirtualCasinoLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.loggedIn)
            {
                if (!guestAccount)
                    vc.user = SaveNewUser();
                else
                    vc.user = new User("Player", "", 200);
                vc.loggedIn = this.loggedIn;
                vc.UpdateText();
                log.LogSignIn(vc.user.Username);
            }
            else
            {
                e.Cancel = true;
                this.Hide();
            }
            log.LogExit();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Writes the User accounts back to the File.
        /// </summary>
        /// <remarks>Does not write the Logged In User.</remarks>
        /// <returns>The "active" User logged In.</returns>
        public User SaveNewUser()
        {
            User tmp = null;
            using (StreamWriter sw = new StreamWriter(MainMenu.ACCOUNT_FILE))
            {
                foreach (User u in accounts)
                {
                    if (u.Username.Equals(username))
                    {
                        tmp = u;
                        continue;
                    }
                    // Insert Account encryption later
                    sw.WriteLine(u.WriteUser());
                }
            }
            return tmp;
        }
        #endregion
    }
}
