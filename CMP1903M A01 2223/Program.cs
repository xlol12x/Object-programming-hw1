using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {

        static void Main(string[] args)
        {
            //test to make sure everything runs fine
            Console.WriteLine("running test");
            Test t = new Test();
            t.Test1();

            // creates a list to store the shuffled list from the method ShuffleCardPack 
            // creates a list of not shuffled cards from _pack as well
            // then picks shuffling method out of the 3
            List<string> shufflecards = new List<string>();
            List<string> notShuffled = new List<string>();
            Pack unsortedCards = new Pack();
            notShuffled = unsortedCards._Pack();
            Console.Write("which shuffle do you want:1-fisher yates, 2-riffle, 3-no shuffle, anything else-no shuffle  ");
            var choice = Console.ReadLine();
            int ifChoiceInt;

            if (int.TryParse(choice, out ifChoiceInt))
                Pack.ShuffleCardPack(Convert.ToInt32(choice), ref shufflecards);
            else
                Console.WriteLine("This is not a number!-defaulted to no shuffle");

            //picks how many cards you want to pick out of the shuffled deck
            // mutiple if statements needed as int choice and an ivalid choice are different 

            Console.Write("How many cards do you want to take?-if invalid defaults to 1: ");
            var cardsToTake = Console.ReadLine();
            int cardsToTakeInt;

            if (int.TryParse(cardsToTake, out cardsToTakeInt))
            {
                if (shufflecards == null)
                    Pack.dealCard(Convert.ToInt32(cardsToTake), notShuffled);

                else
                    Pack.dealCard(Convert.ToInt32(cardsToTake), shufflecards);
            }
            else
                Pack.Deal(notShuffled);
        }
    }
}

