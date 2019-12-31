using System;
using System.Linq;

namespace LanguageFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            // generics
            var gl = new GenericList<int>();
            gl.Add(1);

            // delegates
            Func<int, int> multBy10 = n => n * 10;
            Console.WriteLine(multBy10(5));
            Console.WriteLine(multBy10(7));

            // lambdas
            var books = new BookRepository().GetBooks();
            var expensiveBooks = books.FindAll(b => b.Price > 10);
            foreach (var book in expensiveBooks)
            {
                Console.WriteLine(book.Title);
            }

            // extension methods
            var longStr = "This is an example of a really long string that doesn't need to be";
            var shortStr = longStr.Shorten(5);
            Console.WriteLine(shortStr);

            // Linq
            var mostExpensiveBook = books.Max(b => b.Price);
            var leastExpensiveBook = books.Min(b => b.Price);
            var find1984 = books.SingleOrDefault(b => b.Title == "1984");
            var getGoodBooks = books.Where(b => b.Price > 10)
                                    .OrderBy(b => b.Title)
                                    .Select(b => b.Title);

            Console.WriteLine("Most expensive: " + mostExpensiveBook);
            Console.WriteLine("Least expensive: " + leastExpensiveBook);
            Console.WriteLine("Does library have 1984?: " + find1984.Title);
            Console.WriteLine("Titles of expensive books ordered: " );
            foreach (var book in getGoodBooks)
            {
                Console.WriteLine("book: " + book);
            }

            // nullable types
            DateTime? date = null;
            DateTime specialDate = date ?? DateTime.Today;
        }
    }
}
