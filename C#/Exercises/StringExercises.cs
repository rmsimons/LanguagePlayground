using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class StringExercises
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter a few numbers seperated by a hyphen");
            var input = Console.ReadLine();
            var numberString = input.Split('-');
            var numbers = new int[numberString.Length];
            for (var i = 0; i < numberString.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numberString[i]);
            }

            var begin = numbers[0];
            var end = numbers[numbers.Length - 1];
            var consecutive = new int[numbers.Length];

            if (begin < end)
            {
                for (var i = 0; i < numbers.Length; i++)
                {
                    consecutive[i] = begin;
                    ++begin;
                }
            } else
            {
                for (var i = 0; i < numbers.Length; i++)
                {
                    consecutive[i] = begin;
                    --begin;
                }
            }

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != consecutive[i])
                {
                    Console.WriteLine("Not Consecutive");
                    return;
                }
            }

            Console.WriteLine("Consecutive");
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter a few numbers seperated by a hyphen");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var numbers = input.Split('-');
            var uniques = new List<string>();
            foreach (var n in numbers)
            {
                if (uniques.Contains(n))
                {
                    Console.WriteLine("Duplicate");
                    return;
                }

                uniques.Add(n);
            }

            Console.WriteLine("No duplicates");
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter a time in the format hh:mm");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            try
            {
                var time = Convert.ToDateTime(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid time");
                return;
            }
            
            Console.WriteLine("Ok.");
        }

        public static void Exercise4()
        {
            Console.WriteLine("Enter a few words seperated by a space");
            var input = Console.ReadLine();
            var name = input
                        .ToLower()
                        .Split(' ');
            var pascalName = "";
            foreach (var s in name)
            {
                pascalName += s.Substring(0, 1).ToUpper() + s.Substring(1);
            }

            Console.WriteLine(pascalName);
        }

        public static void Exercise5()
        {
            Console.WriteLine("Enter an english word.");
            var input = Console.ReadLine().ToLower();
            var vowels = "aeiou";
            var count = 0;
            foreach (var c in input)
            {
                if (vowels.Contains(c.ToString()))
                {
                    ++count;
                }
            }

            Console.WriteLine(count);
        }
    }
}
