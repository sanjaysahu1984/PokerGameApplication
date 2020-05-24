using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
 class StraightFlush : ICheckPockerHand
{
    public bool CheckCards(ICard[] cards)
    {

            return (new Straight()).CheckCards(cards) && (new Flush()).CheckCards(cards);
    }
}

}
