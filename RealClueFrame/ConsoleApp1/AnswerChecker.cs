using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RealClueFrame.PlayerMaker;

namespace RealClueFrame
{
    public class AnswerChecker
    {
        public bool CheckAnswerCards(Player player)
        {
            var answerList = Deck.Instance.AnswerCards.OrderBy(x => x.CardType).ToList();
            var candidateList = player.CandidatedCards.OrderBy(x => x.CardType).ToList();

            for (int i = 0; i < 3; i++)
            {
                if (answerList[i] != candidateList[i])
                    return false;
            }

            return true;
        }
    }
}
