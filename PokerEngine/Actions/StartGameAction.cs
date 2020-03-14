using Poker.Engine.Interfaces;
using Poker.Model;
using Poker.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Engine.Actions
{
    public class StartGameAction : IGameAction
    {
        public bool CanDoAction(IGame game, out string whyNot)
        {
            whyNot = "";
            if (game.GameState!=eGameState.Open)
            {
                whyNot = "Can't start already started game";
                return false;
            }
            return true;
        }

        public bool PerformAction(IGame game)
        {
            game.Deck = new Deck();
            game.GameState = eGameState.Closed;
            //find last dealer
            var p = game.Players.FindIndex(x => x.IsDealer);
            if (p < 0)
            {
                var rnd = new Random();
                game.Players[rnd.Next(game.Players.Count)].IsDealer = true;
            }
            else
            {
                game.Players[p].IsDealer = false;
                game.Players[(p + 1) % game.Players.Count].IsDealer = true;
            }
            return true;
        }
    }
}
