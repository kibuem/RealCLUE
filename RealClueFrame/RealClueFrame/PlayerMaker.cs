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
        //public List<Player> DisprovingPlayersTurn { get; private set; }

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

        /// <summary>
        /// 추리를 반박할 순서에 따라 정렬된 플레이어의 리스트를 반환하는 메소드
        /// </summary>
        /// <param name="playerTurn">지정된 순서에서 현재 턴인 플레이어의 인덱스</param>
        /// <returns></returns>
        public List<Player> SetDisprovingPlayersTurn(int playerTurn)
        {
            return Players.Take(playerTurn).Reverse().Concat(Players.Skip(playerTurn).Reverse()).ToList();
        }

        public bool IsPlayerOn(Point point)
        {
            return false;
        }

        public HashSet<Point> PointsOfPlayrs { get; } = new HashSet<Point>();

        public void AddPlayerLocation(Point point)
        {
            PointsOfPlayrs.Add(point);
        }
    }
}
