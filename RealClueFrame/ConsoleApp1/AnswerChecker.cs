using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using static RealClueFrame.PlayerMaker;

namespace RealClueFrame
{
    public class AnswerChecker
    {
        public Player GetWinner(Player player)
        {
            var answerList = Deck.Instance.AnswerCards.OrderBy(x => x.CardType).ToList();
            var candidateList = player.CandidatedCards.OrderBy(x => x.CardType).ToList();

            for (int i = 0; i < 3; i++)
            {
                if (answerList[i] != candidateList[i])
                    break;
            }
            return player;
        }

        // TODO : Clue 방에서 player가 추리를 실패했을 경우, PlayerList에서 뺄지
        public void MakeLoser(Player player)
        {
            player.PlayerStatus = PlayerStatus.Loser;
        }
    }
}