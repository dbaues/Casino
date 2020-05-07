using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cards
{
    // The Classes that extend Log.
    /// <summary>
    /// A basic Log element.
    /// </summary>
    /// <remarks>Defines AppendLogFile, LogOpen, and LogExit method.</remarks>
    public abstract class Log
    {
        protected virtual string Type { get { return "Form"; } }

        /// <summary>
        /// Appends to the Log file.
        /// </summary>
        /// <param name="s">Appends a DateTime with string s.</param>
        protected void AppendLogFile(string s)
        {
            using (StreamWriter sw = File.AppendText(MainMenu.LOG_FILE))
                sw.WriteLine(String.Format("{0}: {1}", DateTime.Now, s));
        }

        /// <summary>
        /// Logs Opening a Form.
        /// </summary>
        public void LogOpen()
        {
            this.AppendLogFile(String.Format("Opened {0}.", Type));
        }

        /// <summary>
        /// Logs closing a form.
        /// </summary>
        public void LogExit()
        {
            this.AppendLogFile(String.Format("Closed {0}.", Type));
        }
    }

    /// <summary>
    /// Logs Game activites.
    /// Extends Log.
    /// </summary>
    /// <remarks>Defines the LogResult, LogBet, and LogStart methods.</remarks>
    public abstract class GameLog : Log
    {
        protected override string Type { get { return "Game"; } }

        /// <summary>
        /// Logs the Game Result.
        /// </summary>
        /// <param name="result"></param>
        public void LogResult(string result)
        {
            this.AppendLogFile(String.Format("{0} result: {1}.", Type, result));
        }

        /// <summary>
        /// Logs player placing a Bet.
        /// </summary>
        /// <param name="money">An Integer for how much the player bet.</param>
        public void LogBet(int money)
        {
            this.AppendLogFile(String.Format("Player has placed a bet of ${0}", money));
        }

        /// <summary>
        /// Logs the Start of a Game
        /// </summary>
        public void LogStart()
        {
            this.AppendLogFile(String.Format("{0} has started.", Type));
        }
    }

    /// <summary>
    /// Logs BlackJack activities.
    /// Extends GameLog.
    /// </summary>
    public class BlackJackLog : GameLog
    {
        #region Result Values
        // Result Values.
        public static string PLAYER_WIN = "Player has won";
        public static string DEALER_WIN = "Dealer has won";
        public static string PUSH = "Push";
        #endregion

        protected override string Type { get { return "Black Jack"; } }
    }

    /// <summary>
    /// Logs Roulette Activities. 
    /// Extends GameLog.
    /// </summary>
    public class RouletteLog : GameLog
    {
        #region Result Values
        public static string PLAYER_WIN = "Player has won ${0}";
        public static string NO_WIN = "Player did not win";
        #endregion
        #region Bet Placement Values
        // Half Bets.
        public static string REDS = "Reds";
        public static string BLACKS = "Blacks";
        public static string EVENS = "Evens";
        public static string ODDS = "Odds";
        public static string FIRST_HALF = "1 through 18";
        public static string SECOND_HALF = "19 through 36";
        // Third Bets.
        public static string TOP_ROW = "the Top Row";
        public static string MID_ROW = "the Middle Row";
        public static string BOT_ROW = "the Bottom Row";
        public static string FIRST_12 = "1 through 12";
        public static string SECOND_12 = "13 through 24";
        public static string THRID_12 = "25 through 36";
        #endregion

        protected override string Type { get { return "Roulette"; } }

        /// <summary>
        /// Overloads LogResult method to include amount won.
        /// </summary>
        /// <param name="result">A String for the Result.</param>
        /// <param name="amount">An Integer representing the amount won.</param>
        public void LogResult(string result, int amount)
        {
            this.LogResult(String.Format(result, amount));
        }

        /// <summary>
        /// Logs a bet placed on multple numbers.
        /// </summary>
        /// <param name="money">An Integer of the money bet.</param>
        /// <param name="on">A String of the bet made.</param>
        public void LogBet(int money, string on)
        {
            this.LogBet(money);
            this.AppendLogFile(String.Format("Bet place on {0}.", on));
        }

        /// <summary>
        /// Logs a bet placed on 0 - 36, 00.
        /// </summary>
        /// <param name="money">An Integer of the money bet.</param>
        /// <param name="on">An Integer location on which the money is placed.</param>
        public void LogBet(int money, int on)
        {
            if (on == 49)
                this.LogBet(money, "00");
            else
                this.LogBet(money, on.ToString());
        }
    }

    /// <summary>
    /// Logs Roulette Board activities.
    /// Extends Log.
    /// </summary>
    /// <remarks>Doesn't Extend GameLog or RouletteLog as this only logs opens/closes.</remarks>
    public class RouletteBoardLog : Log
    {
        protected override string Type { get { return "Roulette Board"; } }
    }

    /// <summary>
    /// Logs Menu activities.
    /// Extends Log.
    /// </summary>
    public abstract class MenuLog : Log
    {
        protected override string Type { get { return "Menu"; } }

        /// <summary>
        /// Logs a User signing in.
        /// </summary>
        /// <param name="username">A String username of the User that has signed in.</param>
        public virtual void LogSignIn(string username)
        {
            this.AppendLogFile(String.Format("{0} has signed in.", username));
        }

        /// <summary>
        /// Logs a User signing out.
        /// </summary>
        /// <param name="username">A String username of the User signing out.</param>
        public virtual void LogSignOut(string username)
        {
            this.AppendLogFile(String.Format("{0} has signed out.", username));
        }
    }

    /// <summary>
    /// Logs Sign In Menu activties.
    /// Extends MenuLog.
    /// </summary>
    public class SignInLog : MenuLog
    {
        protected override string Type { get { return "Sign In Menu"; } }

        /// <summary>
        /// Logs the creation of a New Account.
        /// </summary>
        /// <param name="username">A String username of the New User created.</param>
        public void LogNewAccount(string username)
        {
            this.AppendLogFile(String.Format("New account created, {0}", username));
        }

        /// <summary>
        /// Logs that a Guest account has Logged in.
        /// </summary>
        public void LogGuest()
        {
            this.AppendLogFile("Signed in as Guest.");
        }

        /// <summary>
        /// Logs a User signing in.
        /// Overrides to add Admin Notice.
        /// </summary>
        /// <param name="username">A String username of the User that has signed in.</param>
        public override void LogSignIn(string username)
        {
            base.LogSignIn(username);
            if (username.Equals("admin"))
                this.AppendLogFile("Admin privileges granted.");
        }
    }

    /// <summary>
    /// Logs Main Menu activities.
    /// Extends MenuLog.
    /// </summary>
    public class MainMenuLog : MenuLog
    { 
        protected override string Type { get { return "Main Menu"; } }

        /// <summary>
        /// Logs viewing the current Log.
        /// </summary>
        public void LogViewLog()
        {
            this.AppendLogFile("View log file.");
        }
    }
}
