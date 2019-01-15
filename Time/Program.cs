using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a time between 00:00 and 23:59");
            var inputTime = Console.ReadLine();
            var rawTime = inputTime.Split(':');

            if (String.IsNullOrWhiteSpace(inputTime) || rawTime.Length != 2)
            {
                Console.WriteLine("Invalid time!");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(rawTime[0]);
                var min = Convert.ToInt32(rawTime[1]);

                if (hour >= 0 && hour <= 23 && min <= 59)
                {
                    Console.WriteLine("OK!");
                }
                else
                {
                    Console.WriteLine("Invalid!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
