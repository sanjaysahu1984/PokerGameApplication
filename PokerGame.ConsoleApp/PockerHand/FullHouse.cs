using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
  class FullHouse : ICheckPockerHand
{
    public bool CheckCards(ICard[] cards)
    {
           
            cards = cards.OrderBy(item => (int)item.CardNumber).ToArray();

           
            bool lowFullHouse = (int)cards[0].CardNumber == (int)cards[1].CardNumber &&
                                (int)cards[1].CardNumber == (int)cards[2].CardNumber &&
                                (int)cards[3].CardNumber == (int)cards[4].CardNumber;

            
            bool highFullHouse = (int)cards[0].CardNumber == (int)cards[1].CardNumber &&
                                 (int)cards[2].CardNumber == (int)cards[3].CardNumber &&
                                 (int)cards[3].CardNumber == (int)cards[4].CardNumber;

            return lowFullHouse || highFullHouse;
        }
}

}
