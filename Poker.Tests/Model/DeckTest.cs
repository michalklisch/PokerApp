using NUnit.Framework;
using Poker.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Tests.Model
{
    [TestFixture]
    public class DeckTest
    {
        [Test]
        public void ConstructorWithWrongArgumentTest()
        {
            Assert.Throws<ArgumentException>(() => new Deck(51));
        }

        [Test]
        public void DefaultConstructorTest()
        {
            var deck = new Deck();           
            Assert.IsNotNull(deck.Cards, "Card list is null");
            Assert.AreEqual(52, deck.Cards.Count, $"Expected 52 cards found {deck.Cards.Count}");
        }

        [Test]
        public void ConstructorTest()
        {
            var deck = new Deck(24);
            Assert.IsNotNull(deck.Cards, "Card list is null");
            Assert.AreEqual(24, deck.Cards.Count, $"Expected 24 cards found {deck.Cards.Count}");
        }


        [Test]
        public void TestInitializeDeck()
        {

        }
    }
}
