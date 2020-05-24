using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
  class OnePair : ICheckPockerHand
{
    public bool CheckCards(ICard[] cards)
    {
          
            if (new FourOfAKind().CheckCards(cards) || new FullHouse().CheckCards(cards) || new ThreeOfAKind().CheckCards(cards) || new TwoPair().CheckCards(cards))
                return false;

           
            cards = cards.OrderBy(item => (int)item.CardNumber).ToArray();

            bool lowPair = (int)cards[0].CardNumber == (int)cards[1].CardNumber;

            bool lowerMiddlePair = (int)cards[1].CardNumber == (int)cards[2].CardNumber;

            
            bool higherMiddlePair = (int)cards[2].CardNumber == (int)cards[3].CardNumber;

           
            bool higherPair = (int)cards[3].CardNumber == (int)cards[4].CardNumber;

            return lowPair || lowerMiddlePair || higherMiddlePair || higherPair;

        }
    }
}
