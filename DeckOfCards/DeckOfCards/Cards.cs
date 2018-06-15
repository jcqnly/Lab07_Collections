using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Cards<T> : IEnumerable
    {
        T[] items = new T[16];

        int count;

        //Adds cards to the deck
        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[count++] = item;
        }

        //this was implemented to get the deck to write to the console
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= count; i++)
            {

                yield return items[i];
            }
        }
        //Magic:
        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
