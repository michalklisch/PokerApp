using NUnit.Framework;
using Poker.Model;
using Poker.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Tests.Model
{
    [TestFixture]
    public class CardTest
    {
        [Test]
        [TestCaseSource(nameof(GetCards))]
        public void TestComparison(Card card, ulong expected)
        {
            Assert.AreEqual(expected, card.CardAsMask);
        }

        private static IEnumerable<TestCaseData> GetCards
        {
            get
            {                                                                                                                           
                yield return new TestCaseData(new Card(eSuit.Club, eRank.two),                                                    0b1UL);
                yield return new TestCaseData(new Card(eSuit.Diamond, eRank.two),                                                0b10UL);
                yield return new TestCaseData(new Card(eSuit.Heart, eRank.two),                                                 0b100UL);
                yield return new TestCaseData(new Card(eSuit.Spade, eRank.two),                                                0b1000UL);                
                yield return new TestCaseData(new Card(eSuit.Diamond, eRank.ten),                0b1000000000000000000000000000000000UL);                
                yield return new TestCaseData(new Card(eSuit.Heart, eRank.ace), 0b100000000000000000000000000000000000000000000000000UL);                
                yield return new TestCaseData(new Card(eSuit.Club, eRank.ace),    0b1000000000000000000000000000000000000000000000000UL);
                yield return new TestCaseData(new Card(eSuit.Spade, eRank.ace),0b1000000000000000000000000000000000000000000000000000UL);
            }
        }

        [Test]
        public void TestSort()
        {
            var list = new List<Card>
            {
                new Card(eSuit.Club, eRank.four),
                new Card(eSuit.Spade, eRank.two),
                new Card(eSuit.Heart, eRank.two),
                new Card(eSuit.Spade, eRank.three)
            };

            list.Sort();
            Assert.AreEqual(     0b0100UL, list[0].CardAsMask);
            Assert.AreEqual(     0b1000UL, list[1].CardAsMask);
            Assert.AreEqual( 0b10000000UL, list[2].CardAsMask);
            Assert.AreEqual(0b100000000UL, list[3].CardAsMask);
        }
    }
}
