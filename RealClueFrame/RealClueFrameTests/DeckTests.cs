using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealClueFrame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealClueFrameTest
{
    [TestClass()]
    public class DeckTests
    {
        public List<Card> AnswerCards { get; private set; }

        [TestMethod()]
        public void 플레이어카드리스트에_정답카드리스트가_안_들어_있는지()
        {
            Deck.Instance.GetPlayerCards();
            Stack<Card> playerCards = new Stack<Card>();

            Assert.IsFalse(playerCards.Any(x => AnswerCards.Contains(x)));
        }
    }
}