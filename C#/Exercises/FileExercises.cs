using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercises
{
    class FileExercises
    {
        public static void Exercise1()
        {
            var path = @"C:\Users\simon\CodingPractice\github.com\rmsimons\LanguagePlayground\C#\Exercises\test\TestFileExercises.txt";
            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                var wordsArray = content.Split(' ');
                Console.WriteLine(wordsArray.Length);
            }
        }

        public static void Exercise2()
        {
            var path = @"C:\Users\simon\CodingPractice\github.com\rmsimons\LanguagePlayground\C#\Exercises\test\TestFileExercises.txt";
            if (File.Exists(path))
            {
                var content = File.ReadAllText(path);
                var wordsArray = content.Split(' ');
                var longest = "";
                foreach (var word in wordsArray)
                {
                    if (word.Length > longest.Length)
                    {
                        longest = word;
                    }
                }

                Console.WriteLine("Longest word in file: " + longest);
            }
        }
    }
}
