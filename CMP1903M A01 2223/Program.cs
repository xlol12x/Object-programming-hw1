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
            // creates a list to store the shuffled list from the method ShuffleCardPack 
            // creates a list of not shuffled cards from _pack as well
            // then picks shuffling method out of the 3
            List<string> shufflecards = new List<string>();
            List<string> notShuffled = new List<string>();
            Pack unsortedCards = new Pack();
            notShuffled = unsortedCards._Pack();
            Console.Write("which shuffle do you want:1-fisher yates 2-riffle 3-no shuffle: ");
            
            var choice = Console.ReadLine();
            int ifChoiceInt;

            if (int.TryParse(choice, out ifChoiceInt))
                if (ifChoiceInt <= 3 && ifChoiceInt >= 1)
                {
                    Pack.ShuffleCardPack(Convert.ToInt32(choice),ref shufflecards);
                }
                else
                {
                    Console.WriteLine("out of bounds-defaulted to no shuffle");
                }
            else
                Console.WriteLine("This is not a number!-defaulted to no shuffle");
            //picks how many cards you want to pick out of the shuffled deck
            // mutiple if statements needed as int choice and an ivalid choice are different 
            Console.Write("How many cards do you want to take?-if invalid defaults to 1: ");
            var cardsToTake = Console.ReadLine();
            int cardsToTakeInt;
            if (int.TryParse(cardsToTake, out cardsToTakeInt))
            {
                if (cardsToTakeInt <= 52 && cardsToTakeInt >= 2 && true == (shufflecards == null))
                {
                    var dealtCards = Pack.dealCard(Convert.ToInt32(cardsToTake), notShuffled);
                    Console.WriteLine("You got these cards...");
                    foreach (string card in dealtCards)
                        Console.WriteLine(card);
                    Console.ReadLine();
                }

                else if (cardsToTakeInt <= 52 && cardsToTakeInt >= 2)
                {
                    var dealtCards = Pack.dealCard(Convert.ToInt32(cardsToTake), shufflecards);
                    Console.WriteLine("You got these cards...");
                    foreach (string card in dealtCards)
                        Console.WriteLine(card);
                    Console.ReadLine();
                }
                else if (cardsToTakeInt == 1 && true == (shufflecards == null))
                {
                    Console.WriteLine("You got this card ..." + Pack.Deal(notShuffled));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You got this card ..." + Pack.Deal(shufflecards));
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("This is not a number!-defaulted to 1 card dealt");
                Console.WriteLine("You got this card ..." + Pack.Deal(notShuffled));
                Console.ReadLine();
            }


        }
    }
}
