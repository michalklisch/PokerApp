using Poker.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Engine
{
    public class Player
    {
        public Guid Id { get; private set; }
        public List<Card> Cards;
        public int Money { get; set; }
        public bool HasTurn { get; set; }
        public bool IsDealer { get; set; }
    }
}
