using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestWithSeperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a series of numbers using ',' to seperate: ");
            var userSeries = Console.ReadLine();
            var userNumbers = userSeries.Split(',');

            var phMax = Convert.ToInt32(userNumbers[0]);
            foreach (var str in userNumbers)
            {
                var number = Convert.ToInt32(str);
                if (number > phMax)
                {
                    phMax = number;
                }
            }
            Console.WriteLine("Highest number is {0}", phMax);
        }
    }
}
