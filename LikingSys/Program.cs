using System;
using System.Collections.Generic;

namespace LikingSys
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>(); 
            while (true)
            {
                Console.Write("Please enter your name or (ENTER) to finish: ");
                var input = Console.ReadLine();
                names.Add(input);

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else if (names.Count == 0)
                {
                    Console.WriteLine("No names entered :(");
                }
                else if (names.Count == 1)
                {
                    Console.WriteLine("Names entered: {0}", names[0]);
                }
                else if (names.Count == 2)
                {
                    Console.WriteLine("Names entered: {0}, {1}", names[0], names[1]);
                }
                else if (names.Count > 2)
                {
                    var remainingNames = names.Count - 2;
                    Console.WriteLine("Names entered: {0}, {1} + {2}", names[0], names[1], remainingNames);
                }
            }
        }
    }
}
