using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealClueUML
{
    public class Game
    {
        private readonly Player[] _players;

        /// <summary>
        /// 정답 카드 3장
        /// </summary>
        public List<Card> AnswerCards
        {
            get => default(int);
            set
            {
            }
        }

        /// <summary>
        /// 게임을 시작하고, 정답 카드를 세팅한다.
        /// </summary>
        public void StartGame()
        {
            throw new System.NotImplementedException();
        }

        public void DistributeCards()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 플레이어가 추리한 카드를 정답 카드와 비교해서 맞으면 True, 틀리면 False를 반환한다.
        /// </summary>
        public bool CheckAnswerCard()
        {
            throw new System.NotImplementedException();
        }
    }
}