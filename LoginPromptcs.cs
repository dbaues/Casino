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
            loggedIn = false;
            guestAccount = false;
            accounts = new List<User>();
            log = new SignInLog();

            using (StreamReader sr = new StreamReader("acc.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    accounts.Add(User.ReadUser(line));
            }
            //accounts.Add(new User("db", "asdf"));
        }
        #endregion

        #region Events
        /// <summary>
        /// Updates the username field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uname_TextChanged(object sender, EventArgs e)
        {
            username = uname.Text;
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
            bool validUName = true;
            foreach(User u in accounts)
            {
                if (u.Username.Equals(username))
                    validUName = false;
            }
            if (validUName)
            {
                accounts.Add(new User(username, password));
                log.LogNewAccount(username);
                confirmLogin_Click(sender, e);
            }
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
        /// Logs closing the Login menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VirtualCasinoLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (loggedIn )
            {
                if (!guestAccount)
                    vc.user = SaveNewUser();
                else
                    vc.user = new User("Player", "", 200);
                vc.UpdateText();
                log.LogSignIn(vc.user.Username);
            }
            log.LogExit();
            vc.loggedIn = this.loggedIn;
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
            using (StreamWriter sw = new StreamWriter("acc.txt"))
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
