using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Deck<T> : IEnumerable
    {   //set the initial size of the array for the deck
        T[] deck = new T[16];

        int count;

        //Adds cards to the deck
        public void Add(T card)
        {
            if (count == deck.Length)
            {
                Array.Resize(ref deck, deck.Length + 1);
            }
            deck[count++] = card;
        }

        //Remove a card
        public void Remove(T card)
        {
            deck[--count] = card;
            Array.Resize(ref deck, deck.Length - 1);
        }

        //shuffle the deck
        //pass it a Deck of type T
        public void Shuffle(Deck<T> deckOfCards)
        {
            Random r = new Random();
            for (int n = count-1; n > 0; --n)
            {
                //The random number generated will not be greater than the length
                int k = r.Next(n + 1);
                //temp is of type T and will now hold the card that will soon be replaced by...
                T temp = deck[n];
                //the random generated number for the deck index
                deck[n] = deck[k];
                //put that card that was taken out back into the deck
                deck[k] = temp;
            }
        }


        //this was implemented to get the deck to write to the console
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return deck[i];
            }
        }
        //Magic:
        IEnumerator IEnumerable.GetEnumerator()
        {
            return deck.GetEnumerator();
        }
    }
}
