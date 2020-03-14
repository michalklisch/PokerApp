using Poker.Engine.Interfaces;
using Poker.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Engine.Actions
{
    public class AddPlayerAction : IGameAction
    {
        private Player playerToAdd;
        public bool CanDoAction(IGame game, out string whyNot)
        {
            whyNot = "";
            if (game.GameState != eGameState.Open)
            {
                whyNot = "Game is already running";
                return false;
            }
            if (playerToAdd is null)
            {
                whyNot = "Player not specified";
                return false;
            }
            return true;
        }

        public bool PerformAction(IGame game)
        {
            game.Players.Add(playerToAdd);
            return true;
        }
    }
}
