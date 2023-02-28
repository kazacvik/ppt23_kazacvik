using System;

namespace Guess_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, i;
            string input;
            Random rnd= new Random();
            x = rnd.Next(1,100);

            Console.WriteLine("Number is generated");

            while (true)
            {
                Console.WriteLine("Guess number:");
                input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine("Ending");
                    break;
                }
                else if (!int.TryParse(input, out i)) {
                    Console.WriteLine("Not a number");
                    continue;
                }
                
                if (x > i) { Console.WriteLine("Try higher"); }
                else if (x < i) { Console.WriteLine("Try lower"); }
                else 
                {
                    Console.WriteLine("You win!");
                    break; 
                }
            }
            

            

        }
    }
}
