using System.Collections.Generic;
using System.Linq;

namespace EventDemo
{
    public class RoomFactory
    {
        #region singleton

        private static RoomFactory _instance;

        public static RoomFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RoomFactory();
                return _instance;
            }
        }

        private RoomFactory()
        {
            var list = new List<Room>();
            list.Add(new Room(RoomId.GameRoom));
            list.Add(new Room(RoomId.Hall));

            _rooms = list.ToDictionary(x => x.RoomId, x => x);
        }

        #endregion

        private Dictionary<RoomId, Room> _rooms { get; set; }

        public Room this[RoomId roomId]
        {
            get { return _rooms[roomId]; }
        }
    }

    public enum CardId
    {
        GameRoom,
        Hall,

        Knife = 10,
        John = 11,

    }

    public enum RoomId
    {
        GameRoom,
        Hall
    }
}