using System;
using System.Collections.Generic;
using System.Linq;
using RealClueFrame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RealClueFrameTest
{
    [TestClass]
    public class PlayerCardTest
    {
        [TestMethod]
        public void 플레이어가_3장의_카드씩_가지고_있는지()
        {
            PlayerMaker.Instance.SetPlayers();

            Deck.Instance.Draw();

            int CardCountNo = PlayerMaker.Instance.Players[0].GameCards.Count;

            Assert.AreEqual(3, CardCountNo);
        }

        //[TestMethod]
        //public void 플레이어가_랜덤으로_카드를_받았는지()
        //{
        //    PlayerMaker.Instance.SetPlayers();

        //    Deck.Instance.Draw();

        //    List<Card> PlayerOneCards = new List<Card>();

        //    PlayerOneCards = PlayerMaker.Instance.Players[0].GameCards;

        //    PlayerMaker.Instance.SetPlayers();

        //    Deck.Instance.Draw();

        //    foreach (var playerOneCard in PlayerOneCards)
        //    {
        //        Assert.IsFalse(PlayerMaker.Instance.Players[0].GameCards.Contains(playerOneCard)); 
        //    }
    }
}

