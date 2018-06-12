using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        public Player(PlayerId playerId)
        {
            PlayerId = playerId;
            GameCards = new List<Card>();
            AddCards(playerCards);
        }

        public PlayerId PlayerId { get; private set; }

        public List<Card> GameCards { get; private set; }

        private Stack<Card> playerCards;

        public List<Card> AddCards(Stack<Card> cards)
        {
            GameCards.Add(playerCards.Pop());
            return cards.ToList();
        }
    }
}
