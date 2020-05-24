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
                      
            while (true)
            {
                Console.WriteLine("*********************Pocker game*****************************");
                Console.WriteLine("Please enter 5 Cards with comma seperated!");
                Console.WriteLine("Example:  AS, 10C, 10H, 3D, 3S ");
               
                Console.WriteLine("*************************************************************");

                String line = Console.ReadLine();


                try
                {
                    IHand hand = new Hand(line.ToUpper());
                    Console.WriteLine(hand.ToString());
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message.ToString()); }


                Console.WriteLine("Enter exit to end the game!");
                 line = Console.ReadLine();
                if (line.Equals("exit"))
                {

                    return;
                }
            }
        }
    }
}
