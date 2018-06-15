using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealClueFrame;

namespace ConsoleApp1
{
    public class DisproveDirector
    {
        public Card Disprove(Player player)
        {
            PlayerMaker.Instance.Players.Where(x => x != player).Reverse();

            var candidateList = player.CandidatedCards.OrderBy(x => x.CardType).ToList();
            
            int cardIndex = 0, playerIndex = 0;
            int j = 0;


            Card card = player.GameCards.Intersect(candidateList).FirstOrDefault();


            //TODO: 추리하는 자신을 제외한 플레이어의 리스트
            List<Player> otherPlayers = PlayerMaker.Instance.Players;

            SummonSuspect(player);

            foreach (var otherPlayer in otherPlayers)
            {
                j++;
                for (int i = 0; i < 3; i++)
                {
                    if (otherPlayer.GameCards[i] == candidateList[i])
                        //otherPlayer.GameCards[i];
                        cardIndex = i;
                    playerIndex = j;
                }
            }

            return otherPlayers[playerIndex].GameCards[cardIndex];
        }

        private Player SummonSuspect(Player player)
        {
            var candidateList = player.CandidatedCards.OrderBy(x => x.CardType).ToList();

            var suspectCardIdList = candidateList.Where(x => x.CardType == CardType.Suspect).Select(x => x.CardId).ToList();

            var p = PlayerMaker.Instance.Players.Find(x => suspectCardIdList.Contains((CardId) x.PlayerId));

            return p;
        }
    }
}
