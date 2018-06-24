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
        /// <summary>
        /// Give user options to view, add or shuffle a card
        /// Checks if user inputs one of the choices given
        /// </summary>
        public static void Options()
        {
            Console.WriteLine("Welcome!");
                                  
        }

        /// <summary>
        /// Instantiate Cards based on enum values
        /// Instantiate a Deck of type Card and fill it with the created cards
        /// Add a card
        /// Remove a card
        /// Shuffle the deck
        /// </summary>
        public static void DisplayCards()
        {
            //create objects of Card type
            //pass in the 2 enums for each
            Cards card1 = new Cards((Values)1, (SuitsinDeck)1);
            Cards card2 = new Cards((Values)1, (SuitsinDeck)2);
            Cards card3 = new Cards((Values)1, (SuitsinDeck)3);
            Cards card4 = new Cards((Values)1, (SuitsinDeck)4);
            Cards card5 = new Cards((Values)2, (SuitsinDeck)1);
            Cards card6 = new Cards((Values)2, (SuitsinDeck)2);
            Cards card7 = new Cards((Values)2, (SuitsinDeck)3);
            Cards card8 = new Cards((Values)2, (SuitsinDeck)4);
            Cards card9 = new Cards((Values)3, (SuitsinDeck)1);
            Cards card10 = new Cards((Values)3, (SuitsinDeck)2);
            Cards card11 = new Cards((Values)3, (SuitsinDeck)3);
            Cards card12 = new Cards((Values)3, (SuitsinDeck)4);
            Cards card13 = new Cards((Values)4, (SuitsinDeck)1);
            Cards card14 = new Cards((Values)4, (SuitsinDeck)2);
            Cards card15 = new Cards((Values)4, (SuitsinDeck)3);
            Cards card16 = new Cards((Values)4, (SuitsinDeck)4);

            //Collections initializer
            //add all the cards that were instantiated
            Deck<Cards> DeckOfCards = new Deck<Cards> {
                card1, card2, card3, card4, card5, card6, card7, card8,
                card9, card10, card11, card12, card13, card14, card15, card16
            };

            //GetEnumerator was implemented in the Deck class
            //display the entire deck
            foreach (Cards card in DeckOfCards)
            {
                Console.WriteLine($"{card.Values} of {card.SuitsinDeck}");
            }
            Console.WriteLine();
            Console.Read();
            Console.Clear();
            //adding a card to the deck requires an instantiation of a new Card object
            Console.WriteLine("Let's add a Ten of Spades to the deck.");
            Cards card17 = new Cards((Values)5, (SuitsinDeck)1);
            DeckOfCards.Add(card17);
            foreach (Cards card in DeckOfCards)
            {
                Console.WriteLine($"{card.Values} of {card.SuitsinDeck}");
            }
            Console.Read();

            Console.WriteLine("Let's remove that Ten of Spades from the deck.");
            DeckOfCards.Remove(card16);
            Console.Read();
            Console.Clear();
            foreach (Cards card in DeckOfCards)
            {
                Console.WriteLine($"{card.Values} of {card.SuitsinDeck}");
            }
            Console.Read();

            Console.WriteLine("Let's shuffle the deck: ");
            DeckOfCards.Shuffle(DeckOfCards);
            foreach (Cards card in DeckOfCards)
            {
                Console.WriteLine($"{card.Values} of {card.SuitsinDeck}");
            }
            Console.Read();

            //Options();
        }
    }
}
