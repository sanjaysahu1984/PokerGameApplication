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
            // Check if the hand is not a three pair but better.    
            if ((new FourOfAKind()).CheckCards(cards) || (new FullHouse()).CheckCards(cards))
                return false;

            // Sort cards by CardNumber.
            cards = cards.OrderBy(item => (int)item.CardNumber).ToArray();

            // Check for 3 cards of the same CardNumber and two high unmatched cards.
            // a a a b c
            bool lowThreeOfAKind = (int)cards[0].CardNumber == (int)cards[1].CardNumber &&
                                    (int)cards[1].CardNumber == (int)cards[2].CardNumber;

            // Check for 3 cards of the same CardNumber, one low unmatched card and one high unmatched card.
            // a b b b c
            bool middleThreeOfAKind = (int)cards[1].CardNumber == (int)cards[2].CardNumber &&
                                      (int)cards[2].CardNumber == (int)cards[3].CardNumber;

            // Check for 3 cards of the same CardNumber and two low unmatched cards
            // a b c c c
            bool highThreeOfAKind = (int)cards[2].CardNumber == (int)cards[3].CardNumber &&
                                     (int)cards[3].CardNumber == (int)cards[4].CardNumber;

            return lowThreeOfAKind || middleThreeOfAKind || highThreeOfAKind;
        }
}
}
