using Poker.Model.Enums;
using System;

namespace Poker.Model
{
    public class Card : IComparable, IComparable<Card>
    {
        public eSuit Suit { get; private set; }
        public eRank Rank { get; private set; }

        public Card(eSuit suit, eRank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            var card = obj as Card;
            if (card == null)
                throw new ArgumentException("Object is not a Card");
            return CardAsMask.CompareTo(card.CardAsMask);
        }

        public ulong CardAsMask
        {
            get
            {
                return (1UL << ((int)Rank * 4 + (int)Suit));
            }
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}s";
        }

        public int CompareTo(Card other)
        {
            if (other == null) return 1;
            return CardAsMask.CompareTo(other.CardAsMask);
        }
    }
}
