using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    /// <summary>
    /// An array of Cards.
    /// </summary>
    public class Deck
    {
        #region Fields
        private Card[] Cards { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a Deck of Cards. (All 52 Standard)
        /// </summary>
        public Deck()
        {
            Cards = new Card[52];
            GetDeck();
            Shuffle();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Generates the Deck.
        /// </summary>
        public void GetDeck()
        {
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                string Suit = "";
                if (i == 0)
                    Suit = "Hearts";
                else if (i == 1)
                    Suit = "Spades";
                else if (i == 2)
                    Suit = "Diamonds";
                else if (i == 3)
                    Suit = "Clubs";

                for(int j = 1; j <= 13; j++)
                {
                    Cards[index] = new Card(j, Suit, index);
                    index++;
                }
            }
        }

        /// <summary>
        /// Shuffles the Deck.
        /// </summary>
        public void Shuffle()
        {
            Random rng = new Random();
            int len = Cards.Length;
            while(len > 1)
            {
                int k = rng.Next(len--);
                Card tmp = Cards[len];
                Cards[len] = Cards[k];
                Cards[k] = tmp;
            }
        }

        /// <summary>
        /// Prints the Deck.
        /// </summary>
        public void PrintDeck()
        {
            for(int i = 0; i < Cards.Length - 1; i++)
            {
                Console.WriteLine(Cards[i].ToString() + "\n");
            }
        }

        /// <summary>
        /// Gets the first card in the deck and shifts the deck.
        /// </summary>
        /// <returns>The Card at the top of the Deck.</returns>
        public Card GetTopCard()
        {
            Card top = Cards[0];
            for (int i = 1; i < Cards.Length; i++)
            {
                Cards[i - 1] = Cards[i];
            }
            Cards[Cards.Length - 1] = top;
            return top;
        }
        #endregion
    }
}
