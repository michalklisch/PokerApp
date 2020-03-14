using Poker.Engine.Interfaces;
using Poker.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Engine.Actions
{
    public class DealCardsAction : IGameAction
    {
        public bool CanDoAction(IGame game, out string whyNot)
        {
            whyNot = "";
            if (game.GameState != eGameState.Closed)
            {
                whyNot = "Can't deal cards in this state";
                return false;
            }
            return true;
        }

        public bool PerformAction(IGame game)
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (var p in game.Players)
                {
                    p.Cards.Add(game.Deck.RemoveTopCard());
                }
            }
            game.GameState = eGameState.PreFlop;
            return true;
        }
    }
}
