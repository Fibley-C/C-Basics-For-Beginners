using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");
            var getNumberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            var getNumberTwo = Convert.ToInt32(Console.ReadLine());

            if (getNumberOne > getNumberTwo)
            {
                Console.WriteLine("The larger number is " + getNumberOne);
            }
            else if (getNumberTwo > getNumberOne)
            {
                Console.WriteLine("The larger number is " + getNumberTwo);
            }
            else
            {
                Console.WriteLine("Ummmmmmm...");
            }

        }
    }
}
