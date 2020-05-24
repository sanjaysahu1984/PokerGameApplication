using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
   class FourOfAKind : ICheckPockerHand
{
    public bool CheckCards(ICard[] cards)
    {
          
            cards = cards.OrderBy(item => (int)item.CardNumber).ToArray();

            bool lowFourOfAKind = (int)cards[0].CardNumber == (int)cards[1].CardNumber &&
                                  (int)cards[1].CardNumber == (int)cards[2].CardNumber &&
                                  (int)cards[2].CardNumber == (int)cards[3].CardNumber;

          
            bool highFourOfAKind = (int)cards[1].CardNumber == (int)cards[2].CardNumber &&
                                   (int)cards[2].CardNumber == (int)cards[3].CardNumber &&
                                   (int)cards[3].CardNumber == (int)cards[4].CardNumber;

           
            return lowFourOfAKind || highFourOfAKind;
        }
}
}
