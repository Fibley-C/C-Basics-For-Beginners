using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input some names seperated with a space: ");
            var input = Console.ReadLine();

            Console.WriteLine(ConvertToPascal(input));
        }

        public static string ConvertToPascal (string input)
        {
            var variableName = "";
            foreach (var name in input.Split(' '))
            {
                var pascalName = char.ToUpper(name[0]) + name.ToLower().Substring(1);
                variableName += pascalName;
            }
            return variableName;
        }
    }
}
