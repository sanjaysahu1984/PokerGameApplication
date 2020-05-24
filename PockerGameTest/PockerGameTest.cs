using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerGame.ConsoleApp;

namespace PockerGameTest
{
    [TestClass]
    public class PockerGameTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckMinFiveCardsInHand()
        {
            string cardarray = "10C, 10H, 3D, 3S";
            IHand hand = new Hand(cardarray);
            Assert.AreEqual("Please enter five cards!", hand.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckInValidCardType()
        {
            string cardarray = "AA, 10C, 10H, 3D, 3S";
            IHand hand = new Hand(cardarray);
            Assert.AreEqual("Please enter valid card type!", hand.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckInValidCardNumber()
        {
            string cardarray = "AA, 10C, 11H, 3D, 3S";
            IHand hand = new Hand(cardarray);
            Assert.AreEqual("Please Enter valid Card Number!", hand.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CheckDuplicateCardType()
        {
            string cardarray = "10C, 10C, 10H, 3D, 3S";
            IHand hand = new Hand(cardarray);
            Assert.AreEqual("Duplicate Cards not allowed!", hand.ToString());
        }

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

        [TestMethod]
        public void CheckValidHandValuesHighCard()
        {
            string cardarray = "Qc, 10c, 7d, 5c, 4d";
            IHand hand = new Hand(cardarray);
            Assert.AreEqual("High Card", hand.ToString());
        }

        [TestMethod]
        public void CheckValidHandValuesonepair()
        {
            string cardarray = "6d, 6h, qs, 8c, 7d";
            IHand hand = new Hand(cardarray);
            Assert.AreEqual("One Pair", hand.ToString());
        }

        [TestMethod]
        public void CheckValidHandValuesthreeofakind()
        {
            string cardarray = "2d, 2s, 2c, ks, 6h";
            IHand hand = new Hand(cardarray);
            Assert.AreEqual("Three Of A Kind", hand.ToString());
        }

        [TestMethod]
        public void CheckValidHandValuesstraight()
        {
            string cardarray = "AC, KC, QD, JS, 10S";
            IHand hand = new Hand(cardarray);
            Assert.AreEqual("Straight", hand.ToString());
        }

        [TestMethod]
        public void CheckValidHandValuesflush()
        {
            string cardarray = "qc, jc, 7c, 6c, 5c";
            IHand hand = new Hand(cardarray);
            Assert.AreEqual("Flush", hand.ToString());
        }

        [TestMethod]
        public void CheckValidHandValuesfullhouse()
        {
            string cardarray = "3c, 3s, 3d, 6c, 6h";
            IHand hand = new Hand(cardarray);
            Assert.AreEqual("Full House", hand.ToString());
        }
    }
}
