using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Options();
        }

        public static void Options()
        {
            Console.WriteLine("Pick 1, 2, 3, or 4.\n" +
               "1. View the Deck\n" +
               "2. Add a card\n" +
               "3. Shuffle\n" +
               "4. Exit");
            int selection = 0;
            try
            {
                selection = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Pick 1, 2, 3, or 4.");
            }
            finally
            {
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        ListOfCards();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Options();
                        break;
                }
            }
            Options();
        }

        public static void ListOfCards()
        {
            //Collections initializer
            Cards<string> ourDeckOfCards = new Cards<string>();
            ourDeckOfCards.Add("Ace Of Spades");
            ourDeckOfCards.Add("King Of Spades");
            ourDeckOfCards.Add("Queen Of Spades");
            ourDeckOfCards.Add("Jack Of Spades");
            ourDeckOfCards.Add("Ace Of Hearts");
            ourDeckOfCards.Add("King Of Hearts");
            ourDeckOfCards.Add("Queen Of Hearts");
            ourDeckOfCards.Add("Jack Of Hearts");
            ourDeckOfCards.Add("Ace Of Diamonds");
            ourDeckOfCards.Add("King Of Diamonds");
            ourDeckOfCards.Add("Queen Of Diamonds");
            ourDeckOfCards.Add("Jack Of Diamonds");
            ourDeckOfCards.Add("Ace Of Clubs");
            ourDeckOfCards.Add("King Of Clubs");
            ourDeckOfCards.Add("Queen Of Clubs");
            ourDeckOfCards.Add("Jack Of Clubs");
            //GetEnumerator was implemented
            foreach (string suit in ourDeckOfCards)
            {
                Console.WriteLine(suit);
            }
            Console.Read();
            Console.Clear();
        }
    }
}
