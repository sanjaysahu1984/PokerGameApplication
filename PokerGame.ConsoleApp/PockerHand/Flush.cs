using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
    class Flush : ICheckPockerHand
{
    public bool CheckCards(ICard[] cards)
    {
            cards = cards.OrderBy(item => (int)item.CardType).ToArray();

            int maxCardIndex = cards.Length - 1;

          
            return cards[0].CardType.Equals(cards[maxCardIndex].CardType);

        }
    }
}
