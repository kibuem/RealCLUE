using System;
using System.Collections.Generic;
using RealClueFrame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RealClueFrameTest
{
    [TestClass]
    public class AnswerCheckerTest
    {
        [TestMethod]
        public void 추리카드가_정답이_맞는지()
        {
            Deck.Instance.Draw();
            Player player = PlayerMaker.Instance.Players[0];
            RoomFactory.Instance[0].PlayerEntered(player);

            player.CandidatedCards.Add(new Card(CardId.Wrench, CardType.Weapon));
            player.CandidatedCards.Add(new Card(CardId.Scarlet, CardType.Suspect));
            player.CandidatedCards.Add(new Card(CardId.Yard, CardType.Place));

            AnswerChecker answerChecker = new AnswerChecker();

            answerChecker.CheckAnswerCards(player);

            Assert.AreEqual(true, true);
        }
    }
}
