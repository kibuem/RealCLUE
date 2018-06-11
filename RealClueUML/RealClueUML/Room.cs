using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealClueUML
{
    public class Room
    {
        /// <summary>
        /// 해당하는 방의 이름
        /// </summary>
        private string _roomName;

        /// <summary>
        /// 방의 이름(Key), 카드의 타입과 이름(Value)
        /// </summary>
        public System.Collections.Generic.Dictionary<string, System.Enum> RoomItems
        {
            get => default(int);
            set
            {
            }
        }
    }
}