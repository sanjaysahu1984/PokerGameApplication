using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerGame.ConsoleApp;

namespace PockerGameTest
{
    [TestClass]
    public class PockerGameTest
    {
        [TestMethod]
        public void CheckValidHandValuesTwoPair()
        {
            string cardarray = "AS, 10C, 10H, 3D, 3S";
            IHand hand = new Hand(cardarray);
           Assert.AreEqual("Two Pair",  hand.ToString());
        }

        [TestMethod]
        public void CheckValidHandValuesfourofakind()
        {
            string cardarray = "3S, 3C, 3H, 3D, 4C";
            IHand hand = new Hand(cardarray);
            Assert.AreEqual("Four Of A Kind", hand.ToString());
        }

        [TestMethod]
        public void CheckValidHandValuesStaightFlush()
        {
            string cardarray = "QH, JH, 10H, 8H, 9H";
            IHand hand = new Hand(cardarray);
            Assert.AreEqual("Straight Flush", hand.ToString());
        }

        //[TestMethod]
        //public void CheckValidHandValues()
        //{
        //    string cardarray = "AS, 10C, 10H, 3D, 3S";
        //    IHand hand = new Hand(cardarray);
        //    Assert.AreEqual("Two Pair", hand.ToString());
        //}
    }
}
