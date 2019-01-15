using System;
using System.IO;
using System.Collections.Generic;

namespace TextFileWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllText(@"C:\temp\Test.txt");
            var count = 0;
            foreach (var word in file)
                count++;
            Console.WriteLine("There are {0} words in the file!", count);
        }
    }
}
