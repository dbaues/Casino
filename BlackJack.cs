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
    /// The Main BlackJack Class.
    /// </summary>
    public partial class BlackJack : Form
    {
        #region Fields
        private Deck D { get; set; }
        private Hand Dealer { get; set; }
        private Hand Player { get; set; }
        private int DWins, PWins;
        private bool Stood;
        private bool BetPlaced;
        private bool GameStarted;
        private int Money;
        private int Bet;
        private User user;
        private BlackJackLog log;
        #endregion

        #region Properties
        public User User 
        {   
            get { return user; }
            set { user = value; } 
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructs and instance of BlackJack.
        /// </summary>
        public BlackJack()
        {
            BlankSlateProtocol();
            InitializeComponent();
            log = new BlackJackLog();
            DealerName.Text = "Dealer";
            PlayerName.Text = "Player";
            DWins = 0;
            PWins = 0;
        }
        #endregion

        #region Events
        /// <summary>
        /// Deals the initial deal.
        /// </summary>
        /// <remarks>Only if the bet is placed.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Deal_Click(object sender, EventArgs e)
        {
            if (BetPlaced)
            {
                InitialDeal();
                log.LogStart();
                Stood = false;
                GameStarted = true;
            }
        }

        /// <summary>
        /// User hits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hit_Click(object sender, EventArgs e)
        {
            if ((!Stood) && (GameStarted) && (!BetPlaced))
            {
                DrawCard(Player);
                if (Player.GetCount() > 21)
                {
                    CurrentCard.Text = "Bust! Dealer Wins.";
                    Stood = true;
                    DealerWin();
                }
                UpdateText();
            }
        }

        /// <summary>
        /// User stands.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stand_Click(object sender, EventArgs e)
        {
            if ((!Stood) && (GameStarted))
            {
                Stood = true;
                BetPlaced = false;
                Dealer.Dealer = false;
                UpdateText();
                if (Dealer.GetCount() < Player.GetCount())
                {
                    while (Dealer.GetCount() <= 16)
                        DrawCard(Dealer);
                }
                CheckWin();
            }
        }

        /// <summary>
        /// Places the users bet.
        /// </summary>
        /// <remarks>All non numeral bets are set to default 1.</remarks>
        /// <remarks>Any negative signs will be ignored.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void betBtn_Click(object sender, EventArgs e)
        {
            if (BetPlaced == false && user.Bank >= 1)
            {
                // Gets the Bet amount.
                // Negative signs are ignored.
                try { Bet = Math.Abs(int.Parse(BetOptions.Text)); }
                catch (Exception) { Bet = 1; }

                // Default bet.
                if (BetOptions.Text.Equals(""))
                    BetOptions.Text = "1"; 

                // Subtracts Bet from bank and places the bet.
                if (Bet <= user.Bank)
                {
                    user.Bank -= Bet;
                    log.LogBet(Bet);
                    BetPlaced = true;
                    Stood = false;
                    Bank.Text = "$ " + user.Bank.ToString();
                }
                else
                    CurrentCard.Text = "You Don't have enough.";
            }
            else if (user.Bank <= 0)
                CurrentCard.Text = "Better Luck next time.";
        }

        /// <summary>
        /// Runs the BlackJack closing procedure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlackJack_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.LogExit();
            e.Cancel = true;
            this.Hide();
        }

        /// <summary>
        /// Runs the BlackJack opening procedure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlackJack_Shown(object sender, EventArgs e)
        {
            log.LogOpen();
            PlayerName.Text = user.Username;
            Money = User.Bank;
            Bank.Text = Money.ToString();
            //UpdateText();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Deals the First 4 cards in the Game.
        /// </summary>
        /// <remarks>Checks to see if the Deal results in a Result.</remarks>
        private void InitialDeal()
        {
            BlankSlateProtocol();
            CurrentCard.Text = "";

            D.Shuffle();
            DrawCard(Player);
            DrawCard(Player);
            DrawCard(Dealer);
            DrawCard(Dealer);
            Stood = false;

            if (Player.GetCount() == 21 && Dealer.GetCount() != 21)
            {
                CurrentCard.Text = "BlackJack! You Win!";
                PlayerWin();
            }
            else if (Dealer.GetCount() == 21 && Player.GetCount() != 21)
            {
                Dealer.Dealer = false;
                CurrentCard.Text = "Dealer Wins.";
                DealerWin();
            }
            UpdateText();
            log.LogStart();
        }

        /// <summary>
        /// Draws a card to add to Hand H.
        /// </summary>
        /// <param name="H">A Hand instance that checks if a card can be added.</param>
        private void DrawCard(Hand H)
        {
            if (H.GetCount() <= 20)
            {
                Card tmp = D.GetTopCard();
                H.AddCard(tmp);
                UpdateText();
            }
        }

        /// <summary>
        /// Updates the Game forms text.
        /// </summary>
        public void UpdateText()
        {
            PlayersHand.Text = Player.GetHand();
            DealersHand.Text = Dealer.GetHand();
            DealerWins.Text = DWins.ToString();
            PlayerWins.Text = PWins.ToString();
            Bank.Text = "$ " + user.Bank.ToString();
        }

        /// <summary>
        /// Checks to see if a win resulted.
        /// </summary>
        private void CheckWin()
        {
            if (Dealer.GetCount() > 21)
            {
                CurrentCard.Text = "Dealer Bust! You Win!";
                PlayerWin();
            }
            else if (Player.GetCount() > Dealer.GetCount())
            {
                CurrentCard.Text = "You Win!";
                PlayerWin();
            }
            else if (Player.GetCount() == Dealer.GetCount())
            {
                CurrentCard.Text = "Push.";
                user.Bank += Bet;
                log.LogResult(BlackJackLog.PUSH);
            }
            else
            {
                CurrentCard.Text = "Dealer Wins.";
                DealerWin();
            }
            //BlankSlateProtocol();
            UpdateText();
        }

        /// <summary>
        /// Essentially a constructor, Sets most values to default value.
        /// </summary>
        public void BlankSlateProtocol()
        {
            //Functions as Constructor for Reseting the Game.
            D = new Deck();
            Dealer = new Hand(true);
            Player = new Hand(false);
            Stood = false;
            BetPlaced = false;
            GameStarted = false;
            //Bet = 0;
        }
        #endregion

        #region Winnings
        /// <summary>
        /// Player was won.
        /// </summary>
        private void PlayerWin()
        {
            PWins++;
            user.Bank += 2 * Bet;
            CurrentCard.Text += " +$" + (Bet * 2).ToString();
            UpdateText();
            log.LogResult(BlackJackLog.PLAYER_WIN);
        }

        /// <summary>
        /// Dealer has won.
        /// </summary>
        private void DealerWin()
        {
            DWins++;
            Bet = 0;
            UpdateText();
            log.LogResult(BlackJackLog.DEALER_WIN);
        }
        #endregion
    }
}
