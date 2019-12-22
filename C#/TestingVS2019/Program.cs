using System;
using System.Collections.Generic;
using TestingVS2019.Math;

namespace TestingVS2019
{
    class Program
    {
        static void Main(string[] args)
        {
            // object operations
            var steve = new Person();
            steve.FirstName = "Steve";
            steve.LastName = "Bytheway";
            steve.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            // array operations
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "jack", "john", "mary" };

            // string operations
            var firstName = "Hary";
            var lastName = "Harryman";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}.", firstName, lastName);
            var formattedNames = string.Join(", ", names);

            Console.WriteLine(formattedNames);

            // verbatim strings
            var text = @"Hi John,
                        Please look into the following paths:
                        c:\folder1\folder2
                        c:\folder3\folder4";
            Console.WriteLine(text);

            // enum operations
            var method = ShippingMethod.Express;
            Console.WriteLine((int) method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod) methodId);

            // enum with strings
            Console.WriteLine(method);
            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);

            // ref and val type operations
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            // control flow operations
            var hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            } else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            } else
            {
                Console.WriteLine("It's evening.");
            }

            var isGoldCustomer = true;

            /*float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }*/

            var price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We have a promotion.");
                    break;

                default:
                    Console.WriteLine("Does not compute.");
                    break;
            }

            // loop operations
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var name = "John Smith";
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var c in name)
            {
                Console.WriteLine(c);
            }

            var j = 0;
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }

                j++;
            }

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                   Console.WriteLine("@Echo: " + input);
                   continue;
                }

                break;
            }

            // random class
            var random = new Random();
            const int PasswordLength = 10;

            var buffer = new char[PasswordLength];
            for (var i = 0; i < PasswordLength; i++)
            {
                buffer[i] = (char) ('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);


            // working with arrays and lists
            var numbersArray = new[] { 3, 8, 5, 2, 9 };

            // length
            Console.WriteLine("Length: " + numbersArray.Length);

            // IndecOf()
            var index = Array.IndexOf(numbersArray, 2);
            Console.WriteLine("Index of 2: " + index);

            // Clear()
            Array.Clear(numbersArray, 0, 2);

            // Copy()
            var another = new int[3];
            Array.Copy(numbersArray, another, 2);

            // Sort()
            Array.Sort(another);

            // Reverse()
            Array.Reverse(numbersArray);

            var numberList = new List<int>() { 1, 2, 3, 4 };
            numberList.Add(1);
            numberList.AddRange(new int[3] { 5, 6, 7 });
            foreach (var n in numberList)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Index of 1: " + numberList.IndexOf(1));
            Console.WriteLine("Last index of 1: " + numberList.LastIndexOf(1));
            Console.WriteLine("Count: " + numberList.Count);
            numberList.Remove(1);
            numberList.Clear();
               
        }
    }

    // Use enum when you have multiple constants that can be grouped together.
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
}
