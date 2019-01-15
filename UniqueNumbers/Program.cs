using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberLst = new List<string>();
            while (true)
            {
                Console.Write("Please enter a number (or Quit to exit): ");
                var number = Console.ReadLine();

                if (number == "Quit")
                {
                    Console.WriteLine("Unique numbers entered: ");
                    numberLst.ForEach(Console.WriteLine);
                    break;
                }
                else if (numberLst.Contains(number))
                {
                    continue;
                }
                else
                {
                    numberLst.Add(number);
                }
            }
        }
    }
}
