﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Deck<T> : IEnumerable
    {   //set the initial size of the array for the deck
        T[] deck = new T[16];

        int count;

        /// <summary>
        /// Adds a card
        /// </summary>
        /// <param name="card"></param>
        public void Add(T card)
        {
            if (count == deck.Length)
            {
                Array.Resize(ref deck, deck.Length + 1);
            }
            deck[count++] = card;
        }

        /// <summary>
        /// Removes a card
        /// </summary>
        /// <param name="card"></param>
        public bool Remove(T card)
        {
            //this method removes the most recently added card, so...
            if(card == null)
            {
                return false;
            }
            //the if statement is to catch if a card's value is null
            //it was added for testing purposes
            deck[--count] = card;
            Array.Resize(ref deck, deck.Length - 1);
            return true;
        }

        /// <summary>
        /// Shuffle the deck of type T
        /// </summary>
        /// <param name="deckOfCards"></param>
        public bool Deal(Deck<T> deckOfCards)
        {
            try
            {
                Random r = new Random();
                for (int n = count - 1; n > 0; --n)
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
                return true;
            }
            catch
            {
                return false;
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
