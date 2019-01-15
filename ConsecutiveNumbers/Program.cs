using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input some consecutive numbers (use a '-' to split): ");
            var input = Console.ReadLine();

            var rawNumbers = input.Split('-');

            var numberList = new List<int>();

            foreach (var number in rawNumbers)
            {
                numberList.Add(Convert.ToInt32(number));
            }

            Console.WriteLine(numberList);
            // var convertedNumbers = Convert.ToInt32(rawNumbers);

            // Console.WriteLine(convertedNumbers);
        }
    }
}
