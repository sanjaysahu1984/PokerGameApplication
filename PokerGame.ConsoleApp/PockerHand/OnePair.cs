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
            // Check whether the hand is not a one pair but better.
            if (new FourOfAKind().CheckCards(cards) || new FullHouse().CheckCards(cards) || new ThreeOfAKind().CheckCards(cards) || new TwoPair().CheckCards(cards))
                return false;

            // Sort cards by CardNumber.
            cards = cards.OrderBy(item => (int)item.CardNumber).ToArray();

            // Check for two cards of the same CardNumber in the lower position. 
            // a a b c d
            bool lowPair = (int)cards[0].CardNumber == (int)cards[1].CardNumber;

            // Check for two cards of the same CardNumber in the lower middle position.
            // a b b c d
            bool lowerMiddlePair = (int)cards[1].CardNumber == (int)cards[2].CardNumber;

            // Check for two cards of the same CardNumber in the upper middle position.
            // a b c c d
            bool higherMiddlePair = (int)cards[2].CardNumber == (int)cards[3].CardNumber;

            // Check for two cards of the same CardNumber in the higher position.
            // a b c d d
            bool higherPair = (int)cards[3].CardNumber == (int)cards[4].CardNumber;

            return lowPair || lowerMiddlePair || higherMiddlePair || higherPair;

        }
    }
}
