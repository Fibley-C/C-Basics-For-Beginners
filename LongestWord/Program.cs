using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllText(@"C:\temp\Test2.txt");
            var list = new List<string>();
            foreach (var word in file.Split(' '))
                list.Add(word);

            var longest = list[0].Count();
            var longestWord = "";
            foreach (var word in list)
                if (word.Count() > longest)
                {
                    longestWord = word;
                }
            Console.WriteLine(longestWord);
        }
    }
}
