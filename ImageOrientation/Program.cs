using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageOrientation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the width of your image (px): ");
            var getWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the height of your image (px): ");
            var getHeight = Convert.ToInt32(Console.ReadLine());

            if (getWidth > getHeight)
            {
                Console.WriteLine("Your image is in landscape!");
            }
            else if (getHeight > getWidth)
            {
                Console.WriteLine("Your image is in portait!");
            }
            else
            {
                Console.WriteLine("Your image is scuffed!");
            }
        }
    }
}
