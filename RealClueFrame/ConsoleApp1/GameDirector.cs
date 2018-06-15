using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealClueFrame;

namespace ConsoleApp1
{
    public delegate bool NewRoundBeginningHandler();

    public class GameDirector
    {
        #region singleton
        private static GameDirector _instance;

        public static GameDirector Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameDirector();
                return _instance;
            }
        }

        private GameDirector()
        {
            _players = PlayerMaker.Instance.Players;
            _turnNo = 1;
            _runGame = true;
        }
        #endregion

        #region NewGameBegun event things for C# 3.0
        public event EventHandler<NewGameBegunEventArgs> NewGameBegun;

        protected virtual void OnNewGameBegun(NewGameBegunEventArgs e)
        {
            if (NewGameBegun != null)
                NewGameBegun(this, e);
        }

        private NewGameBegunEventArgs OnNewGameBegun()
        {
            NewGameBegunEventArgs args = new NewGameBegunEventArgs();
            OnNewGameBegun(args);

            return args;
        }

        /*private NewGameBegunEventArgs OnNewGameBegunForOut()
        {
            NewGameBegunEventArgs args = new NewGameBegunEventArgs();
            OnNewGameBegun(args);

            return args;
        }*/

        public class NewGameBegunEventArgs : EventArgs
        {


            /*public NewGameBegunEventArgs()
            {
            }

            public NewGameBegunEventArgs()
            {

            }*/
        }
        #endregion

        private bool _runGame;

        public event NewRoundBeginningHandler NewRoundBeginning;

        private List<Player> _players;

        private int _turnNo;

        private Deck _deck;

        public void Run()
        {
            while (_runGame)
            {
                bool beginnable = NewRoundBeginning();

                if (beginnable == false)

                    break;

                StartRound();
            }
        }

        private void StartRound()
        {
            OnNewGameBegun();
            Deck.Instance.Draw();
            PlayerMaker.Instance.SetPlayers();
        }

        public void GoTurn()
        {
            _turnNo++;
        }
    }
}
