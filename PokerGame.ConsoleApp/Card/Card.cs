using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
    class Card : ICard
    {

        public CardNumber CardNumber { get;  set; }
        public CardType CardType { get;  set; }

        public Card(string cardnumber, char cardtype)
        {
            setCardNumber(cardnumber);
            setCardType(cardtype);
          
        }

        public int CompareTo(ICard other)
        {
            return this.CardNumber.CompareTo(other.CardNumber);
        }

        public bool Equals(ICard other)
        {
            return this.CardType.Equals(other.CardType) &&
                this.CardNumber.Equals(other.CardNumber);
        }

        //public override bool Equals(object other)
        //{
        //    return this.Equals(other as Card);
        //}

        public void setCardNumber(string cardnumber)
        {
            int cardnum = 0;
            bool success = Int32.TryParse(cardnumber, out cardnum);
            if (success) {
                if (cardnum >= 2 && cardnum <= 14)
                {
                    this.CardNumber = (CardNumber)cardnum;

                }
                else
                {
                    throw new Exception("Entered card rank is out of range!");
                }
            }
                else
            {
                switch (cardnumber)
                {
                    case "A":
                        this.CardNumber = CardNumber.Ace;
                        break;
                    case "K":
                        this.CardNumber = CardNumber.King;
                        break;
                    case "Q":
                        this.CardNumber = CardNumber.Queen;
                        break;
                    case "J":
                        this.CardNumber = CardNumber.Jack;
                        break;
                    default:
                        throw new Exception("Please enter valid card type!");

                }
            }
           
        }

        public void setCardType(char cardtype)
        {
            switch(cardtype)
            {
                case 'C':
                    this.CardType = CardType.Club;
                    break;
                case 'D':
                    this.CardType = CardType.Diamond;
                    break;
                case 'H':
                    this.CardType = CardType.Heart;
                    break;
                case 'S':
                    this.CardType = CardType.Spade;
                    break;
                default:
                    throw new Exception("Please enter valid card type!");
                    
            }
                        
        }
    }
}
