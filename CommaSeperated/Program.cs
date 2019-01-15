using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommaSeperated
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers;
            while (true)
            {
                Console.WriteLine("Please eneter a lsit using (,) as a sepereator: ");
                var userList = Console.ReadLine();
                numbers = userList.Split(',');

                if (String.IsNullOrWhiteSpace(userList) || numbers.Length < 5)
                {
                    Console.WriteLine("Invalid List!");
                    continue;
                }
                else
                {
                    break;
                }
            }

            var numList = new List<int>();
            foreach (var number in numbers)
                numList.Add(Convert.ToInt32(number));

            var smallest = new List<int>();
            while (smallest.Count < 3)
            {
                var min = numList[0];
                foreach (var number in numList)
                {
                    if (number < min)
                        min = number;
                }
                smallest.Add(min);

                numList.Remove(min);
            }

            Console.WriteLine("Your numbers are the following: ");
            foreach (var number in smallest)
                Console.WriteLine(number);
        }
    }
}    
