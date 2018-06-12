using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealClueFrame
{
    public class Player
    {
        public Player(PlayerId playerId)
        {
            PlayerId = playerId;
            GameCards = new List<Card>();
        }

        public PlayerId PlayerId { get; private set; }

        public List<Card> GameCards { get; private set; }

        //private Stack<Card> playerCards;

        public List<Card> AddCards(Stack<Card> cards)
        {
            GameCards.Add(cards.Pop());
            return cards.ToList();
        }

        public List<Card> CandidatedCards { get; private set; }

        /// <summary>
        /// Player가 방에 들어갔을 때 추리하는 카드를 가져온다.
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public List<Card> GetCandidatedCards(RoomId roomId, List<Card> cards)
        {
            var room = RoomFactory.Instance[roomId];

            List<Card> candidatedCards = new List<Card>();
            candidatedCards.AddRange(cards.FindAll(x => x.CardType == CardType.Suspect || x.CardType == CardType.Weapon));
            candidatedCards.AddRange(cards.FindAll(x => x.CardType == CardType.Place && (int)x.CardId == (int)room.RoomId));

            return CandidatedCards = candidatedCards;
        }
    }
}
