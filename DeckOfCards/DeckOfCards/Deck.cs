using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Deck<T> : IEnumerable
    {   //set the initial size of our array
        T[] deck = new T[16];

        int count;

        //Adds cards to the deck
        public void Add(T card)
        {
            if (count == deck.Length)
            {
                Array.Resize(ref deck, deck.Length * 2);
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
