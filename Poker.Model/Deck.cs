using Poker.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker.Model
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }

        public Deck() : this(52) { }
    
        public Deck(int size)
        {
            if (size % 4 != 0)
                throw new ArgumentException("Deck size must be a multiply of 4");
            InitializeDeck(size);
            Shuffle(new Random());
        }

        private void InitializeDeck(int size)
        {
            Cards = new List<Card>();
            foreach (var s in Enum.GetValues(typeof(eSuit)).Cast<eSuit>())
            {
                foreach (var r in Enum.GetValues(typeof(eRank)).Cast<eRank>().Take(size/4))
                {
                    Cards.Add(new Card(s, r));
                }
            }
        }

        private void Shuffle(Random rng)
        {
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }

        public Card RemoveTopCard()
        {
            if (Cards.Count == 0)
                throw new Exception("No cards in deck");
            var c = Cards[Cards.Count - 1];
            Cards.Remove(c);
            return c;
        }
    }
}
