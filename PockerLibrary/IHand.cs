using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
  public  interface IHand
    {
         ICard[] CardInHand { get; set; }
        void CreateCardsfromString(string cards);
        string GetCardInHandString(ICard[] cardinhand);

        bool CheckDuplicateCard(string[] cardinhand);

    }
}
