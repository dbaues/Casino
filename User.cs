using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    /// <summary>
    /// This Class represents A User and its attributes.
    /// </summary>
    public class User
    {
        #region Fields
        private int _bank;
        private string _username;
        private string _password;
        private bool _admin = false;
        private DateTime _lastPlayed;
        #endregion

        #region Properties
        public int Bank { get { return _bank; } set { _bank = value; } }
        public string Username { get { return _username; } }
        public string Password { get { return _password; } }
        public bool AdminPrivileges { get { return _admin; } }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a User Instance. (New User)
        /// </summary>
        /// <param name="u">A String username.</param>
        /// <param name="p">A String password.</param>
        public User(string u, string p)
        {
            this._username = u;
            this._password = p;
            this._bank = 100;
            this._lastPlayed = DateTime.Now;
            if (_username.Length > 0 && _username.Equals("admin"))
                this._admin = true;
        }

        /// <summary>
        /// Creates a User Instance. (Obsolete)
        /// </summary>
        /// <param name="u">A String username.</param>
        /// <param name="p">A String password.</param>
        /// <param name="b">An Integer representing the User's current money.</param>
        public User(string u, string p, int b)
        {
            // Made Obsolete by third Constructor.
            this._username = u;
            this._password = p;
            this._bank = b;
        }

        /// <summary>
        /// Creates a User Instance.
        /// </summary>
        /// <param name="u">A String username.</param>
        /// <param name="p">A String password.</param>
        /// <param name="b">An Integer representing the User's current Money.</param>
        /// <param name="lp">A DateTime representing the last Date played.</param>
        public User(string u, string p, int b, DateTime lp)
        {
            this._username = u;
            this._password = p;
            this._bank = b;
            this._lastPlayed = lp;
            if (_username.Equals("admin"))
                this._admin = true;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Logs in a User.
        /// </summary>
        /// <param name="u">A String Username.</param>
        /// <param name="p">A String Password.</param>
        /// <returns>True if u and p matches User Username and Password.</returns>
        public bool Login(string u, string p)
        {
            if (u.Equals(_username) && p.Equals(_password))
            {
                if (DateTime.Now.Day != _lastPlayed.Day)
                    _bank += 100;
                _lastPlayed = DateTime.Now;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Converts a User object to String.
        /// </summary>
        /// <returns>A String representation of a User object.</returns>
        public string WriteUser()
        {
            return String.Format("{0} {1} {2} {3}", _username, _password, _bank, _lastPlayed);
        }

        /// <summary>
        /// Converts a string to User.
        /// </summary>
        /// <param name="s">A string representation of a User.</param>
        /// <returns>Returns a User object created from param string.</returns>
        public static User ReadUser(string s)
        {
            string[] userData = s.Split(' ');
            return new User(userData[0], userData[1], int.Parse(userData[2]), DateTime.Parse(userData[3]));
        }
        #endregion
    }
}
