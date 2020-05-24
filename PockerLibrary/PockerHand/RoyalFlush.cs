using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
   class RoyalFlush : ICheckPockerHand
{
    public bool CheckCards(ICard[] cards)
    {
           return ((new StraightFlush().CheckCards(cards)) && (cards[4].CardNumber == CardNumber.Ace));
    }
}

}
