using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string cardarray = "AS, 10C, 10H, 3D, 3S";
            //IHand hand = new Hand(cardarray);
            //Console.WriteLine(hand.ToString());
            //Console.ReadKey();

            
            while (true)
            {
                Console.WriteLine("*********************Pocker game*****************************");
                Console.WriteLine("Please enter 5 Cards with comma seperated or type exit to exit the game!");
                Console.WriteLine("Example:  AS, 10C, 10H, 3D, 3S ");
              
                String line = Console.ReadLine();
                if (line.Equals("exit"))
                {
                 
                    return; 
                }
              
                try
                {
                    IHand hand = new Hand(line.ToUpper());
                    Console.WriteLine(hand.ToString());
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message.ToString()); }

               
            }
        }
    }
}
