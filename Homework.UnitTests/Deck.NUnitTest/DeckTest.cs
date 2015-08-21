using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Santase.Logic.Cards;

namespace NUnit.Test
{
    [TestFixture]
    public class DeckTest
    {
        [Test]
        public void TestCountOfCardsInNewDeckInstanceIsGreaterThanZero()
        {
            Deck deckCards = new Deck();
            int initialCardsCount = deckCards.CardsLeft;
            Assert.Greater(initialCardsCount, 0);
        }
        [Test]
        public void TestNextCardGotFromTheDeckIsNotNull()
        {
            Deck deckCards = new Deck();
            int initialCardsCount = deckCards.CardsLeft;
            Assert.Greater(initialCardsCount, 0);
            Card nextCard = deckCards.GetNextCard();
            Assert.IsNotNull(nextCard);
        }

        [Test]
        public void TestValidCardsCountAfterGettingTheNextCardFromTheDeck()
        {
            Deck deckCards = new Deck();
            int initialCardsCount = deckCards.CardsLeft;
            Card nextCard = deckCards.GetNextCard();
            Assert.AreEqual(initialCardsCount - 1, deckCards.CardsLeft);
        }

        [Test]
        [ExpectedException(typeof(Santase.Logic.InternalGameException))]
        public void TestGetNextCardFromEmptyDeckThrowsException()
        {
            Deck deckCards = new Deck();
            int cardsCount = deckCards.CardsLeft;
            Card card = deckCards.GetNextCard();
            for (int i = 1; i <= cardsCount; i++)
            {
                card = deckCards.GetNextCard();
            }
        }

        [Test]
        public void TestTrumpCardIsAtTheTopOfDeck()
        {
            Deck deckCards = new Deck();
            int cardsCount = deckCards.CardsLeft;
            Card topCard = deckCards.GetNextCard();
            for (int i = 1; i < cardsCount; i++)
            {
                topCard = deckCards.GetNextCard();
            }
            Assert.AreEqual(topCard, deckCards.GetTrumpCard);
            Assert.AreSame(topCard, deckCards.GetTrumpCard);
        }

        [Test]
        [TestCase(CardSuit.Heart, CardType.King)]
        [TestCase(CardSuit.Heart, CardType.Ace)]
        [TestCase(CardSuit.Spade, CardType.Jack)]
        [TestCase(CardSuit.Heart, CardType.Queen)]
        [TestCase(CardSuit.Diamond, CardType.Ten)]
        public void TestChangeTrumpCardShouldProperlyUpdateBothTrumpCardAndDeckTopCard(CardSuit suit, CardType type)
        {
            Deck deckCards = new Deck();
            Card newTrumpCard = new Card(suit, type);
            deckCards.ChangeTrumpCard(newTrumpCard);
            int cardsCount = deckCards.CardsLeft;
            Card topCard = deckCards.GetNextCard();
            for (int i = 1; i < cardsCount; i++)
            {
                topCard = deckCards.GetNextCard();
            }
            Assert.AreEqual(topCard, newTrumpCard);
        }

        [Test]
        [TestCase(0)]
        [TestCase(8)]
        [TestCase(14)]
        [TestCase(24)]
        public void TestGettingCardsFromDeckShouldProperlyUpdateTheCountOfCardsLeft(int countOfCardsToGet)
        {
            Deck deckCards = new Deck();
            Card card = deckCards.GetNextCard();
            int cardsLeftCount = deckCards.CardsLeft;
            for (int i = 1; i < countOfCardsToGet; i++)
            {
                card = deckCards.GetNextCard();
                cardsLeftCount--;
            }
            Assert.AreEqual(deckCards.CardsLeft, cardsLeftCount);
        }
    }
}
