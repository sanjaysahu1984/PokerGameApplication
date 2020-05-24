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
            // Check whether the hand is not a two pair but better.
            if (new FourOfAKind().CheckCards(cards) || new FullHouse().CheckCards(cards) || new ThreeOfAKind().CheckCards(cards))
                return false;

            // Sort cards by CardNumber.
            cards = cards.OrderBy(item => (int)item.CardNumber).ToArray();

            // Check for two cards of the same CardNumber and two different cards of the same CardNumber in the low position.
            // a a b b c
            bool lowTwoPair = (int)cards[0].CardNumber == (int)cards[1].CardNumber &&
                              (int)cards[2].CardNumber == (int)cards[3].CardNumber;

            // Check for two cards of the same CardNumber and two different cards of the same CardNumber in the corner positions.
            // a a b c c
            bool cornerTwoPair = (int)cards[0].CardNumber == (int)cards[1].CardNumber &&
                                 (int)cards[3].CardNumber == (int)cards[4].CardNumber;

            // Check for two cards of the same CardNumber and two different cards of the same CardNumber in the high position.
            // a b b c c
            bool highTwoPair = (int)cards[1].CardNumber == (int)cards[2].CardNumber &&
                               (int)cards[3].CardNumber == (int)cards[4].CardNumber;

            return lowTwoPair || cornerTwoPair || highTwoPair;
        }
}
}
