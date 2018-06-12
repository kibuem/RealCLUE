using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealClueFrame
{
    public class PlayerMaker
    {
        #region singleton

        private static PlayerMaker _instance;

        public static PlayerMaker Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new PlayerMaker();
                return _instance;
            }
        }

        private PlayerMaker()
        {
            SetPlayers();
        }

        #endregion

        public List<Player> Players { get; private set; }

        public void SetPlayers()
        {
            List<Player> playerList = new List<Player>();

            playerList.Add(new Player(PlayerId.Scarlet));
            playerList.Add(new Player(PlayerId.Mustard));
            playerList.Add(new Player(PlayerId.White));
            playerList.Add(new Player(PlayerId.Green));
            playerList.Add(new Player(PlayerId.Peacock));
            playerList.Add(new Player(PlayerId.Plum));

            Players = playerList;
        }
    }
}
