using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        // creates cards and sends them to method _Pack in the Pack class
        private int value1;
        private int suit1;
        public int Value
        {
            get { return value1; }

            set
            {
                if (value < 1 || value > 13)
                {
                    Console.WriteLine("Value must be between 1 and 13.");
                }
                value1 = value;
            }
        }
        public int Suit
        {
            get { return suit1; }

            set
            {
                if (value < 1 || value > 13)
                {
                    Console.WriteLine("Value must be between 1 and 13.");
                }
                suit1 = value;
            }
        }
        public string newCard(int i, int j)
        {
            Suit = i;
            Value = j;
            string card = string.Format("{0}{1}", Suit, Value);
            return card;

        }
    }
}


