using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Cards
    {
        //properties for each card that will instantiated will
        //have a value and a suit
        public Values Values { get; set; }
        public SuitsinDeck SuitsinDeck { get; set; }

        //those values will be set to the type of Values and SuitsinDeck
        //declared vith enums in Suits
        public Cards(Values value, SuitsinDeck suitsInDeck)
        {
            Values = value;
            SuitsinDeck = suitsInDeck;
        }
    }
}
