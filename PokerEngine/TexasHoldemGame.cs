using Poker.Model;
using System;
using System.Collections.Generic;

namespace Poker.Engine
{
    public interface IGame
    {
        Guid Id { get; }
        List<Player> Players { get; set; }
        List<Card> Deck { get; set; }
        List<Card> Table { get; set; }
    }

    public class TexasHoldemGame : IGame
    {
        public Guid Id { get; private set; }
        public List<Player> Players { get; set;}
        public Deck Deck { get; set; }
        public List<Card> Table { get; set; }
        //state       

        public TexasHoldemGame()
        {
            Id = Guid.NewGuid();
            Players = new List<Player>();
            Table = new List<Card>();
        }

        public void Start()
        {
            var d = new Deck();
        }

        public void AddPlayer(Player p)
        {
            //check state

            //check space

            Players.Add(p);
        }

        public void Deal()
        {
            //check state
            for (int i = 0; i < 2; i++)
            {
                foreach (var p in Players)
                {
                    p.Cards.Add(Deck.RemoveTopCard());
                }
            }
        }

        public void NextRound()
        {
            //check state
        }
    }

    
}
