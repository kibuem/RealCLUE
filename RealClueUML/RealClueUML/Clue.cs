using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealClueUML
{
    public class Clue
    {
        /// <summary>
        /// 카드타입(Key), GetAllItems로 가져온 각 타입별 카드(Value)
        /// </summary>
        private System.Collections.Generic.Dictionary<System.Enum, List<string>> _clueDictionary;

        public event EventHandler<SetGameItemsEventArgs> SetGameItems;
        public event System.EventHandler<SetRoomItemsEventArgs> SetRoomItems;

        /// <summary>
        /// 게임에 필요한 아이템들을 준비한다.
        /// </summary>
        public void OnSetGameItems()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 각 방안에 준비되어 있을 아이템들을 준비한다.
        /// </summary>
        public void OnSetRoomItems()
        {
            throw new System.NotImplementedException();
        }
    }
}