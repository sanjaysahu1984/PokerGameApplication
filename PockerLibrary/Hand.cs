using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
   public class Hand : IHand
    {
        public ICard[] CardInHand { get; set; }


        public Hand(string cards)
        {
            CreateCardsfromString(cards);
        }

        public void CreateCardsfromString(string cards)
        {
            CardInHand = new Card[5];

            var cardArr=cards.ToUpper().Split(',');
            
            if (cardArr.Length != 5)
                throw new Exception("Please enter five cards!");

            if (CheckDuplicateCard(cardArr))
                throw new Exception("Duplicate Cards not allowed!");

            int i = 0;
            foreach(var c in cardArr)
            {
                string cardValue = c.Trim();
                if (cardValue.Length < 2 && cardValue.Length>3)
                    throw new Exception("Please Enter valid Card Number!");

              string cardNumber = cardValue.Substring(0, cardValue.Length - 1);

                char cardType = cardValue[cardValue.Length - 1];
                CardInHand[i]=new Card(cardNumber, cardType);
                i++;
            }
        }

        public override string ToString()
        {
           
                return GetCardInHandString(CardInHand);
          
        }

        public string GetCardInHandString(ICard[] cardinhand)
        {
            if (new RoyalFlush().CheckCards(cardinhand))
                return "Royal Flush";

            if (new StraightFlush().CheckCards(cardinhand))
                return "Straight Flush";

            if (new FourOfAKind().CheckCards(cardinhand))
                return "Four Of A Kind";

            if (new FullHouse().CheckCards(cardinhand))
                return "Full House";

            if (new Flush().CheckCards(cardinhand))
                return "Flush";

            if (new Straight().CheckCards(cardinhand))
                return "Straight";

            if (new ThreeOfAKind().CheckCards(cardinhand))
                return "Three Of A Kind";

            if (new TwoPair().CheckCards(cardinhand))
                return "Two Pair";

            if (new OnePair().CheckCards(cardinhand))
                return "One Pair";

            return "High Card";
        }

        public bool CheckDuplicateCard(string[] cardinhand)
        {
            for (int i = 0; i < cardinhand.Length; i++)
            {
                for (int j = i + 1; j < cardinhand.Length; j++)
                {
                    if (cardinhand[i].Trim() == cardinhand[j].Trim())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
