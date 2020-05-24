using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
  class ThreeOfAKind : ICheckPockerHand
{
    public bool CheckCards(ICard[] cards)
    {
              
            if ((new FourOfAKind()).CheckCards(cards) || (new FullHouse()).CheckCards(cards))
                return false;

           
            cards = cards.OrderBy(item => (int)item.CardNumber).ToArray();

          
            bool lowThreeOfAKind = (int)cards[0].CardNumber == (int)cards[1].CardNumber &&
                                    (int)cards[1].CardNumber == (int)cards[2].CardNumber;

           
            bool middleThreeOfAKind = (int)cards[1].CardNumber == (int)cards[2].CardNumber &&
                                      (int)cards[2].CardNumber == (int)cards[3].CardNumber;

            
            bool highThreeOfAKind = (int)cards[2].CardNumber == (int)cards[3].CardNumber &&
                                     (int)cards[3].CardNumber == (int)cards[4].CardNumber;

            return lowThreeOfAKind || middleThreeOfAKind || highThreeOfAKind;
        }
}
}
