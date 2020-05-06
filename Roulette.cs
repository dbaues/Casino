using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace Cards
{
    /// <summary>
    /// The Main Roulette class.
    /// </summary>
    public partial class Roulette : Form
    {
        #region Fields
        public List<Bet> bets;
        public List<int> history;
        private RouletteLog log;
        private User _user;
        private int index;
        #endregion

        #region Static Values
        public static int _00 = 37;
        private static int[] Order = {37, 27, 10, 25, 29, 12, 8, 19, 31, 18, 6, 21, 33, 16, 4, 23, 35, 14, 2,
                0, 28, 9, 26, 30, 11, 7, 20, 32, 17, 5, 22, 34, 15, 3, 24, 36, 13, 1};
        public static int[] REDS = {1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36};
        public static int[] BLACKS = {2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35};
        public static int[] TOP_ROW = (from e in Roulette.Order where e % 3 == 0 select e).ToArray();
        public static int[] MID_ROW = (from e in Roulette.Order where e % 3 == 2 select e).ToArray();
        public static int[] BOT_ROW = (from e in Roulette.Order where e % 3 == 1 select e).ToArray();
        #endregion

        #region Properties
        public User User { get { return _user; } set { this._user = value; } }
        #endregion

        #region Constructor
        public Roulette()
        {
            InitializeComponent();
            BlankSlateProtocol();
            log = new RouletteLog();
        }
        #endregion

        #region Events
        /// <summary>
        /// Opens the Roulette Board for placing bets.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void placeBets_Click(object sender, EventArgs e)
        {
            new RouletteBoard(this).Show();
        }

        /// <summary>
        /// Spins the Wheel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            log.LogStart();
            int tmp = 38, sleepTime = 60;
            for (int k = 0; k < 5; k++)
            {
                index = 0;
                for (int j = 0; j < tmp; j++)
                {
                    UpdateText();
                    index++;
                    Thread.Sleep(sleepTime);
                }
                if(k == 3) 
                { 
                    tmp = new Random().Next(0, 38);
                    sleepTime = 100;
                }
            }
            index--;
            this.history.Add(Order[index]);
            if (Order[index] == 37) { this.result.Text = "00"; }
            else { this.result.Text = Order[index].ToString(); }
            this.CheckWin(Order[index]);
        }

        /// <summary>
        /// Executes the Roulette open sequence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Roulette_Shown(object sender, EventArgs e)
        {
            try
            {
                this.playerName.Text = _user.Username;
                UpdateText();
            }
            catch (Exception) { }
            log.LogOpen();
        }

        /// <summary>
        /// Executes the Roulette exit procedure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Roulette_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.LogExit();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a Bet to the list of Bets.
        /// </summary>
        /// <remarks>Logs the bet.</remarks>
        /// <param name="money">An Integer that represents the Bet amount.</param>
        /// <param name="location">An Integer that represents the board location.</param>
        public void AddBet(int money, int location)
        {
            bets.Add(new Bet(money, location));
            if (location < 37 || location == RouletteBoard._00)
                log.LogBet(money, location);
            // Half bets.
            // Colors.
            else if (location == RouletteBoard.REDS)
                log.LogBet(money, RouletteLog.REDS);
            else if (location == RouletteBoard.BLACKS)
                log.LogBet(money, RouletteLog.BLACKS);
            // Evens/Odds.
            else if (location == RouletteBoard.EVENS)
                log.LogBet(money, RouletteLog.EVENS);
            else if (location == RouletteBoard.ODDS)
                log.LogBet(money, RouletteLog.ODDS);
            // Halfs.
            else if (location == RouletteBoard.FIRST_HALF)
                log.LogBet(money, RouletteLog.FIRST_HALF);
            else if (location == RouletteBoard.SECOND_HALF)
                log.LogBet(money, RouletteLog.SECOND_HALF);
            // Third bets.
            // Twelths.
            else if (location == RouletteBoard.FIRST_12)
                log.LogBet(money, RouletteLog.FIRST_12);
            else if (location == RouletteBoard.SECOND_12)
                log.LogBet(money, RouletteLog.SECOND_12);
            else if (location == RouletteBoard.THIRD_12)
                log.LogBet(money, RouletteLog.THRID_12);
            // Rows.
            else if (location == RouletteBoard.TOP_ROW)
                log.LogBet(money, RouletteLog.TOP_ROW);
            else if (location == RouletteBoard.MID_ROW)
                log.LogBet(money, RouletteLog.MID_ROW);
            else if (location == RouletteBoard.BOT_ROW)
                log.LogBet(money, RouletteLog.BOT_ROW);

        }

        /// <summary>
        /// Essentially the Constructor. Sets most values to their default start.
        /// </summary>
        private void BlankSlateProtocol()
        {
            bets = new List<Bet>();
            history = new List<int>();
        }

        /// <summary>
        /// Updates elements of Roulette.
        /// </summary>
        public void UpdateText()
        {
            this.wheel.Image.Dispose();
            if (index != 0)
                this.wheel.Image = Image.FromFile(String.Format("Boards/board{0}SZ.png", Roulette.Order[index]));
            else
                this.wheel.Image = Image.FromFile("Boards/board00SZ.png");
            this.wheel.Update();
            this.bank.Text = String.Format("${0}", _user.Bank);
        }

        /// <summary>
        /// Checks to see if the Player has won.
        /// </summary>
        private void CheckWin(int result)
        {
            int sumWinnings = 0;
            foreach(Bet b in bets)
            {
                if(b.CheckWin(result))
                    sumWinnings += Bet.WinMultiplier(b.BetType) * b.Amount;
            }

            if(sumWinnings > 0) { log.LogResult(RouletteLog.PLAYER_WIN, sumWinnings); }
            else { log.LogResult(RouletteLog.NO_WIN); }

            resultText.Text = String.Format("{0} has won ${1}", _user.Username, sumWinnings);
            _user.Bank += sumWinnings;
            bets.RemoveRange(0, bets.Count());
            this.UpdateText();
        }
        #endregion
    }

    /// <summary>
    /// An bet to be placed.
    /// </summary>
    public class Bet
    {
        #region Fields
        private int bet;
        private int type;
        #endregion

        #region Properties
        public int Amount { get { return bet; } }
        public int BetType { get { return type; } }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructs a bet.
        /// </summary>
        /// <param name="bet">An Integer representing the money bet.</param>
        /// <param name="loc">An Integer representing the location on the board bet upon.</param>
        public Bet(int bet, int type)
        {
            this.bet = bet;
            this.type = type;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Checks to see if the result results in a win.
        /// </summary>
        /// <param name="loc">An Integer representing a board location.</param>
        /// <returns></returns>
        public bool CheckWin(int result)
        {
            // Strict number conditions.
            if ((type < 37) && (result == type))
                return true;
            // Even/Odd win conditions.
            else if ((result % 2 == 0) && (type == RouletteBoard.EVENS))
                return true;
            else if ((result % 2 == 1) && (type == RouletteBoard.ODDS))
                return true;
            // Colors win conditions.
            else if ((type == RouletteBoard.REDS) && (Roulette.REDS.Contains(result)))
                return true;
            else if ((type == RouletteBoard.BLACKS) && (Roulette.BLACKS.Contains(result)))
                return true;
            // Halfs win conditions.
            else if ((type == RouletteBoard.FIRST_HALF) && (result > 0 && result < 19))
                return true;
            else if ((type == RouletteBoard.SECOND_HALF) && (result > 18 && result < 38))
                return true;
            // Thirds win conditions.
            else if ((type == RouletteBoard.FIRST_12) && (result > 0 && result < 13))
                return true;
            else if ((type == RouletteBoard.SECOND_12) && (result > 12 && result < 25))
                return true;
            else if ((type == RouletteBoard.THIRD_12) && (result > 24 && result < 37))
                return true;
            // Row win conditions.
            else if ((type == RouletteBoard.TOP_ROW) && (Roulette.TOP_ROW.Contains(result)))
                return true;
            else if ((type == RouletteBoard.MID_ROW) && (Roulette.MID_ROW.Contains(result)))
                return true;
            else if ((type == RouletteBoard.BOT_ROW) && (Roulette.BOT_ROW.Contains(result)))
                return true;
            // Zeroes win conditions.
            else if ((type == RouletteBoard._0) && (result == 0))
                return true;
            else if ((type == RouletteBoard._00) && (result == Roulette._00))
                return true;

            return false;
        }

        /// <summary>
        /// Used to multiply a bet by a given Multiplier.
        /// </summary>
        /// <param name="loc">An Integer representing the board location.</param>
        /// <returns>An Integer multiplier to get the winnings.</returns>
        public static int WinMultiplier(int type)
        {
            // Statically defined values.
            if (type < 37 || type == 49)
                return 36;
            else if (type < 43)
                return 2;
            else if (type < 49)
                return 3;
            return 0;
        }

        /// <summary>
        /// Returns a Bet as a String.
        /// </summary>
        /// <returns>A String representing a Bet.</returns>
        public override string ToString()
        {
            string output = "";

            if (type < 37)
                output = type.ToString();
            else if (type == RouletteBoard.REDS)
                output = "Reds";
            else if (type == RouletteBoard.BLACKS)
                output = "Blacks";
            else if (type == RouletteBoard.EVENS)
                output = "Evens";
            else if (type == RouletteBoard.ODDS)
                output = "Odds";
            else if (type == RouletteBoard.FIRST_HALF)
                output = "1 through 18";
            else if (type == RouletteBoard.SECOND_HALF)
                output = "19 through 36";
            else if (type == RouletteBoard.FIRST_12)
                output = "1 through 12";
            else if (type == RouletteBoard.SECOND_12)
                output = "13 through 24";
            else if (type == RouletteBoard.THIRD_12)
                output = "25 through 36";
            else if (type == RouletteBoard.TOP_ROW)
                output = "Top Row";
            else if (type == RouletteBoard.MID_ROW)
                output = "Middle Row";
            else if (type == RouletteBoard.BOT_ROW)
                output = "Bottom Row";
            else if (type == RouletteBoard._00)
                output = "00";

            return String.Format("${0} placed on {1}.", bet, output);
        }
        #endregion
    }
}
