using System.Collections.Generic;

namespace LanguageFeatures
{
    class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "The Giver", Price = 10},
                new Book() {Title = "1984", Price = 12},
                new Book() {Title = "Animal Farm", Price = 11}
            };
        }
    }
}
