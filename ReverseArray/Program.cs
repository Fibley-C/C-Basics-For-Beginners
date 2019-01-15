using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lets reverse your name! Enter your name: ");
            var name = Console.ReadLine();
            var reversedName = ReverseName(name);
            Console.WriteLine("Your name reveresed is: " + reversedName);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            var reversed = new string(array);

            return reversed;
        }
    }
}
