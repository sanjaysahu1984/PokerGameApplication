using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
  public  interface ICard : IComparable<ICard>, IEquatable<ICard>
    {
         CardNumber CardNumber { get;  set; }
         CardType CardType { get;  set; }
        void setCardNumber(string cardnumber);
        void setCardType(char cardtype);

       

    }
}
