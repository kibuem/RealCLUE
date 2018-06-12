using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1Tests
{
    [TestClass]
    public class PlayerCardTest
    {
        public PlayerId PlayerId { get; private set; }
        public List<Card> GameCards { get; private set; }
        private Stack<Card> playerCards;
        private int CardCountNo;

        [TestMethod]
        public void 플레이어가_3장의_카드씩_가지고_있는지()
        {
            PlayerMaker.Instance.SetPlayers();

            List<Card> AddCards(Stack<Card> cards)
            {
                CardCountNo++;
                GameCards.Add(playerCards.Pop());
                return cards.ToList();
            }

            Assert.AreEqual(3, CardCountNo);
        }
    }
}
