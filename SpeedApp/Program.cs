using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the speed of the car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            const int mphOver = 5;

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("OK!");
            }
            else if (carSpeed >= speedLimit + 12)
            {
                Console.WriteLine("License suspended!");
            }
            else
            {
                var demeritPoints = (carSpeed - speedLimit) / mphOver;
                Console.WriteLine("Points added to license: " + demeritPoints);
            }
        }
    }
}
