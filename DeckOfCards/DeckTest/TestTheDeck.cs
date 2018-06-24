using DeckOfCards;
using System;
using Xunit;

namespace DeckTest
{
    public class TestTheDeck
    {
        [Fact]
        public void CanAddCard()
        {
            //arrange
            Cards card = new Cards((Values)1, (SuitsinDeck)4);
            Cards card2 = new Cards((Values)2, (SuitsinDeck)1);

            Deck<Cards> DeckOfCards = new Deck<Cards> {
                card, card2
            };

            //act
            Cards card3 = new Cards((Values)3, (SuitsinDeck)1);
            DeckOfCards.Add(card3);
            int count = 0;
            foreach (Cards item in DeckOfCards)
            {
                count++;
            }
            //assert
            Assert.Equal(3, count);
        }

        [Fact]
        public void CanShowProperties()
        {
            //arrange
            Cards card = new Cards((Values)1, (SuitsinDeck)4);

            //act
            string value = card.Values.ToString();

            //assert
            Assert.Equal("Ace", value);
        }

        [Fact]
        public void CanRemoveCard()
        {
            //arrange
            Cards card = new Cards((Values)1, (SuitsinDeck)4);
            Cards card2 = new Cards((Values)2, (SuitsinDeck)1);
            Cards card3 = new Cards((Values)3, (SuitsinDeck)1);

            Deck<Cards> DeckOfCards = new Deck<Cards> {
                card, card2, card3
            };

            //act
            DeckOfCards.Remove(card3);
            int count = 0;
            foreach (Cards item in DeckOfCards)
            {
                count++;
            }
            //assert
            Assert.Equal(2, count);
        }

        [Fact]
        public void CanRemoveNullCard()
        {
            //arrange
            Cards card = new Cards((Values)1, (SuitsinDeck)4);
            Cards card2 = new Cards((Values)2, (SuitsinDeck)1);
            Cards card3 = new Cards((Values)3, (SuitsinDeck)1);

            Deck<Cards> DeckOfCards = new Deck<Cards> {
                card, card2
            };

            //act
            DeckOfCards.Remove(null);
            int count = 0;
            foreach (Cards item in DeckOfCards)
            {
                count++;
            }
            //assert
            Assert.Equal(2, count);
        }

        [Fact]
        public void CanShuffleDeck()
        {
            //arrange
            Cards card = new Cards((Values)1, (SuitsinDeck)4);
            Cards card2 = new Cards((Values)2, (SuitsinDeck)1);
            Cards card3 = new Cards((Values)3, (SuitsinDeck)1);

            Deck<Cards> DeckOfCards = new Deck<Cards> {
                card, card2, card3
            };

            //act
            DeckOfCards.Deal(DeckOfCards);

            //assert
            Assert.True(DeckOfCards.Deal(DeckOfCards));
        }       
    }
}
