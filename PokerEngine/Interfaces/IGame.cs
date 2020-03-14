using Poker.Model;
using Poker.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Engine.Interfaces
{
    public interface IGame
    {
        Guid Id { get; }
        List<Player> Players { get; set; }
        Deck Deck { get; set; }
        List<Card> Table { get; set; }
        eGameState GameState { get; set; }
    }
}
