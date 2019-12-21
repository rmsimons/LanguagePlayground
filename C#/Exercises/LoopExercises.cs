using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class LoopExercises
    {
        public static void Exercise1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    ++count;
                }
            }

            Console.WriteLine("Count: " + count);
        }

        public static void Exercise2()
        {
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or 'ok' to exit");
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }

                sum += Convert.ToInt32(input);
            }

            Console.WriteLine("Sum: " + sum);
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();
            var num = Convert.ToInt32(input);
            for (var i = num - 1; i > 1; i--)
            {
                num *= i;
            }

            Console.WriteLine(string.Format("{0}! = {1}", input, num));
        }

        public static void Exercise4()
        {
            var random = new Random();
            var num = random.Next(1, 11);

            for (var i = 4; i > 0; i--)
            {
                Console.WriteLine(string.Format("Guess the number. You have {0} chances left", i));
                var inputNum = Convert.ToInt32(Console.ReadLine());
                if (inputNum == num)
                {
                    Console.WriteLine("You won");
                    return;
                }
            }
            
            Console.WriteLine("You lost");
        }

        public static void Exercise5()
        {
            Console.WriteLine("Enter a series of numbers seperated by a comma.");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);
            foreach (var num in numbers)
            {
                var temp = Convert.ToInt32(num);
                if (temp > max)
                {
                    max = temp;
                }
            }

            Console.WriteLine("Max: " + max);
        }
    }
}
