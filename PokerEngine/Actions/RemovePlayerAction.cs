using Poker.Engine.Interfaces;
using Poker.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Engine.Actions
{
    public class RemovePlayerAction : IGameAction
    {
        private Player playerToRemove;
        public RemovePlayerAction(Player player)
        {
            playerToRemove = player;
        }
        public bool CanDoAction(IGame game, out string whyNot)
        {
            whyNot = "";
            if (game.GameState != eGameState.Open)
            {
                whyNot = "Game is already running";
                return false;
            }
            if (playerToRemove is null)
            {
                whyNot = "Player not specified";
                return false;
            }
            return true;
        }

        public bool PerformAction(IGame game)
        {
            game.Players.Remove(playerToRemove);
            return true;
        }
    }
}
