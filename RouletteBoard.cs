using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    /// <summary>
    /// The betting board for Roulette.
    /// </summary>
    public partial class RouletteBoard : Form
    {
        #region Fields
        private Roulette r;
        private RouletteBoardLog log;
        #endregion

        #region Static Values
        // Half bet codes.
        public static int REDS = 37;
        public static int BLACKS = 38;
        public static int EVENS = 39;
        public static int ODDS = 40;
        public static int FIRST_HALF = 41;
        public static int SECOND_HALF = 42;
        // Third bet codes.
        public static int FIRST_12 = 43;
        public static int SECOND_12 = 44;
        public static int THIRD_12 = 45;
        public static int TOP_ROW = 46;
        public static int MID_ROW = 47;
        public static int BOT_ROW = 48;
        // Zero bet codes.
        public static int _00 = 49;
        public static int _0 = 0;
        #endregion

        #region Constructor
        public RouletteBoard(Roulette r)
        {
            InitializeComponent();
            this.log = new RouletteBoardLog();
            this.r = r;
            this.UpdateText();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a bet by getting the amount bet.
        /// </summary>
        /// <param name="location">An Integer representing the board location.</param>
        private void PlaceBet(int location)
        {
            int betAmount;
            try { betAmount = int.Parse(this.options.Text); }
            catch (Exception) { betAmount = 1; }
            if (betAmount <= r.User.Bank)
            {
                r.AddBet(betAmount, location);
                r.User.Bank -= betAmount;
            }
            this.UpdateText();
        }

        /// <summary>
        /// Updates the Money text box.
        /// </summary>
        private void UpdateText()
        {
            money.Text = String.Format("$ {0}", this.r.User.Bank);
        }
        #endregion

        #region Events
        /// <summary>
        /// Views the current Bets.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewBets_Click(object sender, EventArgs e)
        {
            string betList = "";
            foreach(Bet b in r.bets)
                betList += String.Format("{0}\n", b.ToString());
            MessageBox.Show(betList, "Current Bets Placed");
        }

        /// <summary>
        /// Views the current History.
        /// Only the last 10 entries.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void history_Click(object sender, EventArgs e)
        {
            string history = "";
            if (r.history.Count() > 10)
            {
                for (int i = r.history.Count() - 10; i > r.history.Count(); i--)
                    history += String.Format("{0} ", r.history.ElementAt(i));
            }
            else
            {
                foreach (int i in r.history)
                    history += String.Format("{0} ", i);
            }
            MessageBox.Show(history, "History");
        }

        /// <summary>
        /// Clears all the Bets.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_Click(object sender, EventArgs e)
        {
            foreach(Bet b in r.bets)
                r.User.Bank += b.Amount;
            r.bets.RemoveRange(0, r.bets.Count());
            this.UpdateText();
        }

        #region 36 to 1
        #region 1 - 12
        private void button_1_Click(object sender, EventArgs e)
        {
            this.PlaceBet(1);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            this.PlaceBet(2);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            this.PlaceBet(3);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            this.PlaceBet(4);
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            this.PlaceBet(5);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            this.PlaceBet(6);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            this.PlaceBet(7);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            this.PlaceBet(8);
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            this.PlaceBet(9);
        }

        private void button_10_Click(object sender, EventArgs e)
        {
            this.PlaceBet(10);
        }

        private void button_11_Click(object sender, EventArgs e)
        {
            this.PlaceBet(11);
        }

        private void button_12_Click(object sender, EventArgs e)
        {
            this.PlaceBet(12);
        }
        #endregion
        #region 13 - 24
        private void button_13_Click(object sender, EventArgs e)
        {
            this.PlaceBet(13);
        }

        private void button_14_Click(object sender, EventArgs e)
        {
            this.PlaceBet(14);
        }

        private void button_15_Click(object sender, EventArgs e)
        {
            this.PlaceBet(15);
        }

        private void button_16_Click(object sender, EventArgs e)
        {
            this.PlaceBet(16);
        }

        private void button_17_Click(object sender, EventArgs e)
        {
            this.PlaceBet(17);
        }

        private void button_18_Click(object sender, EventArgs e)
        {
            this.PlaceBet(18);
        }

        private void button_19_Click(object sender, EventArgs e)
        {
            this.PlaceBet(19);
        }

        private void button_20_Click(object sender, EventArgs e)
        {
            this.PlaceBet(20);
        }

        private void button_21_Click(object sender, EventArgs e)
        {
            this.PlaceBet(21);
        }

        private void button_22_Click(object sender, EventArgs e)
        {
            this.PlaceBet(22);
        }

        private void button_23_Click(object sender, EventArgs e)
        {
            this.PlaceBet(23);
        }

        private void button_24_Click(object sender, EventArgs e)
        {
            this.PlaceBet(24);
        }
        #endregion
        #region 25 - 36
        private void button_25_Click(object sender, EventArgs e)
        {
            this.PlaceBet(25);
        }

        private void button_26_Click(object sender, EventArgs e)
        {
            this.PlaceBet(26);
        }

        private void button_27_Click(object sender, EventArgs e)
        {
            this.PlaceBet(27);
        }

        private void button_28_Click(object sender, EventArgs e)
        {
            this.PlaceBet(28);
        }

        private void button_29_Click(object sender, EventArgs e)
        {
            this.PlaceBet(29);
        }

        private void button_30_Click(object sender, EventArgs e)
        {
            this.PlaceBet(30);
        }

        private void button_31_Click(object sender, EventArgs e)
        {
            this.PlaceBet(31);
        }

        private void button_32_Click(object sender, EventArgs e)
        {
            this.PlaceBet(32);
        }

        private void button_33_Click(object sender, EventArgs e)
        {
            this.PlaceBet(33);
        }

        private void button_34_Click(object sender, EventArgs e)
        {
            this.PlaceBet(34);
        }

        private void button_35_Click(object sender, EventArgs e)
        {
            this.PlaceBet(35);
        }

        private void button_36_Click(object sender, EventArgs e)
        {
            this.PlaceBet(36);
        }
        #endregion
        #region Zeroes
        private void button_0_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard._0);
        }

        private void button_00_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard._00);
        }
        #endregion
        #endregion
        #region 3 to 1
        private void button_1to12_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard.FIRST_12);
        }

        private void button_13to24_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard.SECOND_12);
        }

        private void button_25to36_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard.THIRD_12);
        }

        private void button_3x_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard.TOP_ROW);
        }

        private void button_3x2_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard.MID_ROW);
        }

        private void button_3x1_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard.BOT_ROW);
        }
        #endregion
        #region 2 to 1
        private void button_1to18_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard.FIRST_HALF);
        }

        private void button_19to36_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard.SECOND_HALF);
        }

        private void button_EVEN_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard.EVENS);
        }

        private void button_ODD_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard.ODDS);
        }

        private void button_RED_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard.REDS);
        }

        private void button_BLACK_Click(object sender, EventArgs e)
        {
            this.PlaceBet(RouletteBoard.BLACKS);
        }
        #endregion

        /// <summary>
        /// Executes the Roulette Boards opening procedure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RouletteBoard_Shown(object sender, EventArgs e)
        {
            this.r.BoardOpen = true;
            this.log.LogOpen();
        }

        /// <summary>
        /// Executes the Roulette Boards closing procedure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RouletteBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.r.BoardOpen = false;
            this.log.LogExit();
            this.r.UpdateText();
        }
        #endregion
    }
}
