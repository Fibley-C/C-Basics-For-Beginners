using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var userNumbers = new List<int>();
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (userNumbers.Contains(number))
                {
                    Console.WriteLine("Number already exists! Please enter a new one.");
                    i--;
                    continue;
                }
                else
                {
                    userNumbers.Add(number);
                }
            }
            userNumbers.Sort();
            Console.WriteLine("User numbers are: {0}, {1}, {2}, {3}, {4}", userNumbers[0], userNumbers[1], userNumbers[2], userNumbers[3], userNumbers[4]);
        }
    }
}
