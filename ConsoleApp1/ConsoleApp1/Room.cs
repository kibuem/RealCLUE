using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Room
    {
        public Room(RoomId roomId)
        {
            RoomId = roomId;
        }

        public RoomId RoomId { get; private set; }
    }
}
