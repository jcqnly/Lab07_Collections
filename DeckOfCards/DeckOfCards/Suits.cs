using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Suits
    {
        public Values Values { get; set; }
        public SuitsinDeck Suitsindeck { get; set; }
    }

    public enum Values
    {
        Ace = 1,
        King,
        Queen,
        Jack,
        Ten
    }
    public enum SuitsinDeck
    {
        Spades = 1,
        Hearts,
        Diamonds,
        Clubs,
    }
}
