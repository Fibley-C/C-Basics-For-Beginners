using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOrExit
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentTotal = 0;
            while (true)
            {
                Console.WriteLine("Enter a number (or ok to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                currentTotal += Convert.ToInt32(input);
          
            }
            Console.WriteLine(currentTotal);
        }
    }
}
