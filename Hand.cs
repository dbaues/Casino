using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    /// <summary>
    /// A list of Cards.
    /// </summary>
    public class Hand
    {
        #region Fields
        private List<Card> hand;     //Contains the cards dealt
        public bool Dealer;         //Determines if this hand is the Dealers
        private char D;
        #endregion

        #region Constructor
        /// <summary>
        /// Intantiates a Hand.
        /// </summary>
        /// <param name="Dealer">True if this hand belongs to the Dealer.</param>
        public Hand(bool Dealer)
        {
            this.Dealer = Dealer;
            if(Dealer) { D = 'D'; }
            else { D = 'P'; }
            hand = new List<Card>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds a Card to the hand.
        /// </summary>
        /// <param name="c">A Card to be added.</param>
        public void AddCard(Card c)
        {
            hand.Add(c);
        }

        /// <summary>
        /// Counts the card score.
        /// </summary>
        /// <returns>An Integer of the score of the Hand.</returns>
        public int GetCount()
        {
            int sum = 0;
            Card ace = null;
            foreach(Card element in hand)
            {  
                int val = element.Value;
                if (val >= 10)
                    sum += 10;
                else if (val == 1 && ace == null)
                    ace = element;
                else
                    sum += val;
            }
            if (ace != null)
            {
                if (sum <= 10)
                    sum += 11;
                else
                    sum += 1;
            }

            return sum;
        }

        /// <summary>
        /// Gets the Hand as a string.
        /// </summary>
        /// <returns>A String representing the Hands cards.</returns>
        public string GetHand()
        { 
            string cards = "";
            if(D == 'D')
                cards = GetHandEXP();
            else
                cards = GetHandEXP();
            return cards;
        }

        /// <summary>
        /// Gets the ASCII art of the Hand of Cards.
        /// </summary>
        /// <returns>A 3 line string of the ASCII art for the Cards.</returns>
        private string GetHandEXP()
        {
            int i;
            string nl = Environment.NewLine;
            char[] Lines = { '─', '┌', '┐', '└', '┘', '│' };
            char[] cut = { '[', ']' };

            if (D == 'P')
            {
                string line1 = "";
                for (i = 0; i < hand.Count(); i++)
                    line1 += "___ ";
                line1 = line1.Substring(0, line1.Length - 1);
                line1 += "_" + nl; ;

                string line2 = "";
                for (i = 0; i < hand.Count(); i++)
                {
                    if (hand.ElementAt(i).Value != 10)
                        line2 += "│" + hand.ElementAt(i).toSimpleString().Trim(cut) + " ";
                    else
                        line2 += "│" + hand.ElementAt(i).toSimpleString().Trim(cut);
                }
                line2 += " │" + nl;

                string line3 = "";
                for (i = 0; i < hand.Count(); i++)
                    line3 += "│   ";
                line3 += " │" + nl;

                return @line1 + @line2 + @line3;
            }
            else
            {
                string line1 = "│ ";
                for (i = 0; i < hand.Count(); i++)
                    line1 += "   │";
                line1 += nl;

                string line2 = "│_";
                if (!Dealer)
                {
                    for (i = 0; i < hand.Count(); i++)
                    {
                        if (hand.ElementAt(i).Value != 10)
                            line2 += "_" + hand.ElementAt(i).toSimpleString().Trim(cut) + "│";
                        else
                            line2 += hand.ElementAt(i).toSimpleString().Trim(cut) + "│";
                    }
                }
                else 
                {
                    for (i = 0; i < hand.Count() - 1; i++)
                    {
                        if (hand.ElementAt(i).Value != 10)
                            line2 += "_" + hand.ElementAt(i).toSimpleString().Trim(cut) + "│";
                        else
                            line2 += hand.ElementAt(i).toSimpleString().Trim(cut) + "│";
                    }
                    line2 += "_XX│";
                }
                line2 += nl;
                return @line1 + @line2;
            }
        }
        #endregion
    }
}
