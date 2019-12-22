using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class ListExercises
    {
        public static void Exercise1()
        {
            var people = new List<string>();
            while(true)
            {
                Console.WriteLine("Enter a name (no name to exit): ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                people.Add(input);
            }

            var numLiked = people.Count;
            switch (numLiked)
            {
                case 0:
                    break;

                case 1:
                    Console.WriteLine(string.Format("{0} likes your post.", people[0]));
                    break;

                case 2:
                    Console.WriteLine(string.Format("{0} and {1} like your post.", people[0], people[1]));
                    break;

                default:
                    Console.WriteLine(string.Format("{0}, {1} and {2} others like your post.", people[0], people[1], numLiked - 2));
                    break;
            }
        }

        public static void Exercise2()
        {
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();

            var charArray = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                charArray[name.Length - i] = name[i - 1];
            }

            var reversed = new string(charArray);
            Console.WriteLine("Reversed name: " + reversed);
        }

        public static void Exercise3()
        {
            var numbers = new List<int>();
            while(numbers.Count < 5)
            {
                Console.WriteLine("Enter a number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("Number already entered. Please try again.");
                    continue;
                }

                numbers.Add(input);
            }

            numbers.Sort();
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void Exercise4()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
        }

        public static void Exercise5()
        {
            Console.WriteLine("Enter a list of comma seperated numbers with at least 5 numbers: ");
            while (true)
            {
                var input = Console.ReadLine();
                var numArray = input.Split(",");
                if (numArray.Length < 5)
                {
                    Console.WriteLine("Invalid List. Please try again.");
                    continue;
                }

                Array.Sort(numArray);
                Console.WriteLine(string.Format("3 smallest numbers: {0}, {1}, {2}", numArray[0], numArray[1], numArray[2]));
                break;
            }
        }
    }
}
