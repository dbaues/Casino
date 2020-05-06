using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Cards
{
    /// <summary>
    /// Contains the attributes of Card.
    /// </summary>
    public class Card
    {
        #region Fields
        public int Value { get; }
        public int ID { get; }
        public string Suit { get; }
        private char Char;
        private static char[] Symbol = { '♥', '♠', '♦', '♣' };
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a Card.
        /// </summary>
        /// <param name="val">An Integer representing the value.</param>
        /// <param name="suit">A String representing the suit.</param>
        /// <param name="ID">A unique Integer per Card.</param>
        public Card(int val, string suit, int ID)
        {
            this.Value = val;
            this.Suit = suit;
            this.ID = ID;
            if (Suit[0] == 'H')
                this.Char = Symbol[0];
            else if (Suit[0] == 'S')
                this.Char = Symbol[1];
            else if (Suit[0] == 'D')
                this.Char = Symbol[2];
            else if (Suit[0] == 'C')
                this.Char = Symbol[3];
            //getImage();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Converts a Card to a String.
        /// </summary>
        /// <returns>A String representation of a Card.</returns>
        public string toString()
        {
            string Name = Value.ToString();
            if (Value == 11)
                Name = "Jack";
            else if (Value == 12)
                Name = "Queen";
            else if (Value == 13)
                Name = "King";
            return Name + " of " + Suit;
        }

        /// <summary>
        /// Converts a Card to a Simplified String.
        /// </summary>
        /// <returns>A simple String representation of a Card.</returns>
        public string toSimpleString()
        {
            string tmp = "[";
            if (Value == 1)
                tmp += 'A' + Char.ToString() + ']';
            else if (Value == 11)
                tmp += 'J' + Char.ToString() + ']';
            else if (Value == 12)
                tmp += 'Q' + Char.ToString() + ']';
            else if (Value == 13)
                tmp += 'K' + Char.ToString() + ']';
            else
            {
                tmp += Value.ToString() + Char.ToString() + ']';
            }
            return tmp;
        }
        #endregion
    }
}
