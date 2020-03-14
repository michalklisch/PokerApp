using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Engine.Interfaces
{
    public interface IPlayerAction
    {
        bool CanDoAction(Player player, IGame game, out string whyNot);
        bool PerformAction(Player player, IGame game);
    }
}
