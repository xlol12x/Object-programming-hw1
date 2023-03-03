using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        // initializes the cards and creates a list
        public static List<string> pack;

        public List<string> _Pack()
        {
            Card c = new Card();
            pack = new List<string>();
            for (int i = 1; i <= 4; i++)
                for (int j = 1; j <= 13; j++)
                    pack.Add(c.newCard(i, j));
            return pack;
        }
        // uses _Pack to get the cards to shuffle then picks 3 options 1-fisher yates, 2-riffle
        // or 3 no shuffle 
        public static bool ShuffleCardPack(int choice, ref List<string> pack)
        {
            Pack shufflePack = new Pack();
            pack = shufflePack._Pack();

            if (choice == 1)
            {
                Random _random = new Random();
                int n = pack.Count;
                for (int i = 0; i < (n - 1); i++)
                {
                    int r = i + _random.Next(n - i);
                    string t = pack[r];
                    pack[r] = pack[i];
                    pack[i] = t;
                }
                return true;

            }
            else if (choice == 2)
            {
                int n = pack.Count;
                int half = (n / 2) - 1;
                int j = half + 1;
                for (int i = 0; i <= half; i++)
                {
                    if (i % 2 == 0 || i == 0)
                    {
                        string tmp = pack[i];
                        pack[i] = pack[j];
                        pack[j] = tmp;
                    }
                    j++;
                }
                return true;
            }
            else
                Console.WriteLine("out of bounds-defaulted to no shuffle");
            return false;
        }
        //Gets one card from the shuffled deck
        public static string Deal(List<string> pack)
        {
            Console.WriteLine("You got this card ... " + pack[0]);
            Console.ReadLine();
            return pack[0];
        }
        // Gets muitlple cards from the shuffled deck
        public static List<string> dealCard(int amount, List<string> pack)
        {
            List<string> dealtCards = new List<string>();
            if (amount <= 52 && amount >= 2)
            {
                for (int i = 0; i < amount; i++)
                    dealtCards.Add(pack[i]);

                Console.WriteLine("You got these cards...");
                foreach (string card in dealtCards)
                    Console.WriteLine(card);
                Console.ReadLine();
                return dealtCards;
            }
            else
                dealtCards.Add(Pack.Deal(pack));
            return dealtCards;
        }
    }
}
