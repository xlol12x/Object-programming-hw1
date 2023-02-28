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
        public int Value { get; set; }
        public int Suit { get; set; }

        public string newCard (int i,int j)
        {
            Suit = i;
            Value = j;
            string card = Convert.ToString(Suit) + Convert.ToString(Value);
            return card;
        
        }
    }

}
    

