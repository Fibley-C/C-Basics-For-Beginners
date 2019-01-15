using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input some numbers (eg: 1-2-3)");
            var input = Console.ReadLine();

            var message = DupeCounter(input) ? "Duplicates found!" : "No duplicates in the list!";
            Console.WriteLine(message);
        }

        public static bool DupeCounter (string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                Environment.Exit(0);

            var numberList = new List<int>();

            foreach (var number in input.Split('-'))
                numberList.Add(Convert.ToInt32(number));

            var hasDupe = false;
            var checkList = new List<int>();
            foreach (var number in numberList)
            {
                if (!checkList.Contains(number))
                {
                    checkList.Add(number);
                }
                else
                {
                    hasDupe = true;
                    break;
                }
            }
            return hasDupe;
        }
    }
}
