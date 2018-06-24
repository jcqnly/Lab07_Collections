using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Suits
    {   //set the properties of each Suit
        public Values Values { get; set; }
        public SuitsinDeck Suitsindeck { get; set; }
    }
    //these enum Values and SuitsinDeck will be used
    //when each new card is instantiated
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
