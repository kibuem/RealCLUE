using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealClueFrame
{
    public class Room
    {
        public Room(RoomId roomId)
        {
            RoomId = roomId;
        }

        public RoomId RoomId { get; private set; }

        public void PlayerEntered(Player player)
        {
            player.GetCandidatedCards(RoomId, Deck.Instance.Cards);

            
        }

        //#region EnteredPlayer event things for C# 3.0
        //public event EventHandler<EnteredPlayerEventArgs> EnteredPlayer;

        //protected virtual void OnEnteredPlayer(EnteredPlayerEventArgs e)
        //{
        //    if (EnteredPlayer != null)
        //        EnteredPlayer(this, e);
        //}

        //private EnteredPlayerEventArgs OnEnteredPlayer(Player player)
        //{
        //    EnteredPlayerEventArgs args = new EnteredPlayerEventArgs(player);
        //    OnEnteredPlayer(args);

        //    return args;
        //}

        //private EnteredPlayerEventArgs OnEnteredPlayerForOut()
        //{
        //    EnteredPlayerEventArgs args = new EnteredPlayerEventArgs();
        //    OnEnteredPlayer(args);

        //    return args;
        //}

        //public class EnteredPlayerEventArgs : EventArgs
        //{
        //    public Player Player { get; set; }

        //    public EnteredPlayerEventArgs()
        //    {
        //    }

        //    public EnteredPlayerEventArgs(Player player)
        //    {
        //        Player = player;
        //    }
        //}
        //#endregion
    }
}
