using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Engine.Interfaces
{
    public interface IGameAction
    {
        bool CanDoAction(IGame game, out string whyNot);
        bool PerformAction(IGame game);
    }
}
