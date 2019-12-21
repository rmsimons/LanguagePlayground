using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class ConditionalExercises
    {
        public static void Exercise1()
        {
            Console.Write("Enter a number from 1 - 10: ");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter two numbers: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            var number2 = Convert.ToInt32(Console.ReadLine());
            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine(string.Format("Max: {0}", max));
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter width and height of image: ");
            var width = Convert.ToInt32(Console.ReadLine());
            var height = Convert.ToInt32(Console.ReadLine());
            var orientation = (width > height) ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image is a " + orientation);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        public static void Exercise4()
        {
            Console.WriteLine("Enter speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter speed of car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            var speedOver = carSpeed - speedLimit;

            if (speedOver < 5)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var numberOfDemerits = speedOver / 5;
                if (numberOfDemerits < 12)
                {
                    Console.WriteLine(string.Format("Over limit. {0} demerit(s) awarded.", numberOfDemerits));
                }
                else
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
    }
}
