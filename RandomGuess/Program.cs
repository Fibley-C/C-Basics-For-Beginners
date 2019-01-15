using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var leNumber = random.Next(1, 10);
            Console.WriteLine("Guess a number between 1-10!");
            for (var i = 0; i <= 3; i++)
            {
                Console.WriteLine("Have a guess for le number: ");
                var userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == leNumber)
                {
                    Console.WriteLine("Well done you have guessed le number!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Unlucky bud, try again...");
                }
            }

        }
    }
}
