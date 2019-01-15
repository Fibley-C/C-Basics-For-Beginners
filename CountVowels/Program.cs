using System;

namespace CountVowels
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a word: ");
            var input = Console.ReadLine();
            
            Console.WriteLine("There are {0} vowels in your word", CountVowels(input));
        }

        public static char CountVowels (string input)
        {
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            var count = '0';
            foreach (var character in input)
            {
                foreach (var vowl in vowels)
                {
                    if (vowl == character)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
