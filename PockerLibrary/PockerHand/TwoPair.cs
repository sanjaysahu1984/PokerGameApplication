using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
    class TwoPair : ICheckPockerHand
{
    public bool CheckCards(ICard[] cards)
    {
           
            if (new FourOfAKind().CheckCards(cards) || new FullHouse().CheckCards(cards) || new ThreeOfAKind().CheckCards(cards))
                return false;

          
            cards = cards.OrderBy(item => (int)item.CardNumber).ToArray();

           
            bool lowTwoPair = (int)cards[0].CardNumber == (int)cards[1].CardNumber &&
                              (int)cards[2].CardNumber == (int)cards[3].CardNumber;

          
            bool cornerTwoPair = (int)cards[0].CardNumber == (int)cards[1].CardNumber &&
                                 (int)cards[3].CardNumber == (int)cards[4].CardNumber;

           
            bool highTwoPair = (int)cards[1].CardNumber == (int)cards[2].CardNumber &&
                               (int)cards[3].CardNumber == (int)cards[4].CardNumber;

            return lowTwoPair || cornerTwoPair || highTwoPair;
        }
}
}
