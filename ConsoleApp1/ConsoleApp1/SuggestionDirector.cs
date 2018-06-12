using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SuggestionDirector
    {
        private List<Card> _cards;

        /// <summary>
        /// Player가 방에 들어갔을 때 추리하는 카드를 가져온다.
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public List<Card> GetCandidatedCards(RoomId roomId)
        {
            var list = _cards.ToList();

            var room = RoomFactory.Instance[roomId];

            var cardsToReturn = new List<Card>();
            cardsToReturn.AddRange(list.FindAll(x => x.CardType == CardType.Suspect || x.CardType == CardType.Weapon));
            cardsToReturn.AddRange(list.FindAll(x => x.CardType == CardType.Place && (int)x.CardId == (int)room.RoomId));

            return cardsToReturn;
        }
    }
}
