using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
  class Straight : ICheckPockerHand
{
    public bool CheckCards(ICard[] cards)
    {
           
            cards = cards.OrderBy(item => (int)item.CardNumber).ToArray();

           
            int sequentialRank = (int)cards[0].CardNumber + 1;

           
            for (int i = 1; i < cards.Length; i++)
            {
                if ((int)cards[i].CardNumber != sequentialRank++)
                    return false;
            }

            return true;
        }
}
}
