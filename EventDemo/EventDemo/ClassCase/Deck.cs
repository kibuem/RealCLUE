#region
using System;
using System.Collections.Generic;
using System.Linq;
using EventDemo.Properties;

#endregion

namespace EventDemo
{
    public class Deck
    {
        #region singleton
        private static Deck _instance;

        public static Deck Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Deck();
                return _instance;
            }
        }

        private Deck()
        {
            
        }
        #endregion

        private Stack<Card> _cards;
//
//        /// <summary>
//        /// Deck을 다시 셔플한다
//        /// </summary>
//        public void PrepareNewRound()
//        {
//            _cards = _cards.OrderBy(x => Guid.NewGuid()).ToList();
//            _index = 0;
//
//            //clue에서 data를 받아서 _card에 18장의 카드를 생성한다.
//            Clue.Instance.GameStarting += CluePlayerDeck;
//
//            //이벤트 발생
//            Clue.Instance.SetItems();
//        }

        public void Initialize()
        {
            List<Card> cardList = new List<Card>();

            cardList.Add(new Card(Resources.Deck_Deck_Bathroom, CardType.Place));
            cardList.Add(new Card("John", CardType.Suspect));

            _cards = new Stack<Card>(cardList.OrderBy(x => Guid.NewGuid()));
        }

        public Card[] Draw(int takeCount)
        {
            Card[] cards = new Card[takeCount];
            for (int i = 0; i < takeCount; i++)
                cards[i] = _cards.Pop();

            return cards;
        }

        public int Size()
        {
            return _cards.Count;
        }

        #region Event Callbacks
        private void CluePlayerDeck(object sender, Clue.SetGameItemsEventArgs e)
        {
            Random random = new Random();

            foreach (var item in e.Clues)
            {
                int index = random.Next(item.Value.Count);
                for (int i = 0; i < item.Value.Count; i++)
                {
                    if (i != index)
                        _cards.Add(new Card(item.Value[i], item.Key));
                }
            }
        }
        #endregion

        public List<Card> GetCandidates(RoomId roomId)
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
