using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealClueUML
{
    public class Player
    {

        /// <summary>
        /// Player의 X 좌표
        /// </summary>
        public int X
        {
            get => default(int);
            set
            {
            }
        }

        /// <summary>
        /// Player의 X 좌표
        /// </summary>
        public int Y
        {
            get => default(int);
            set
            {
            }
        }

        /// <summary>
        /// Player의 이름
        /// </summary>
        public string PlayerName
        {
            get => default(int);
            set
            {
            }
        }

        /// <summary>
        /// Player가 가지고 있는 카드의 리스트
        /// </summary>
        public List<Card> PlayerCardList
        {
            get => default(int);
            set
            {
            }
        }

        /// <summary>
        /// Player에게 카드를 추가한다.
        /// </summary>
        public Card[] AddCards()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 게임이 끝나면 Player가 가지고 있는 카드를 없앤다.
        /// </summary>
        internal void ClearPlayerCards()
        {
            throw new System.NotImplementedException();
        }
    }
}