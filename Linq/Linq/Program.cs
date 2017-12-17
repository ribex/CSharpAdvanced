using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // this is how you do it without LINQ
//            var cheapBooks = new List<Book>();
//            foreach (var book in books)
//            {
//                if (book.Price < 10)
//                {
//                    cheapBooks.Add(book);
//                }
//            }

            // LINQ Query Operators
            // equivalent to Extension Methods below
            var cheaperBooks = from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            // LINQ Extension Methods: can chain methods
            // Select used for projections
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);


            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
//                Console.WriteLine(book.Title + " " + book.Price);
            }


            var singleBook = books.Single(b => b.Title == "ASP.NET MVC");
            var singleOrDefaultBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
            var firstBook = books.First(b => b.Title == "C# Advanced Topics");
            var firstOrDefaultBook = books.FirstOrDefault(b => b.Title == "C# Advanced Topics++");
            var lastBook = books.Last(b => b.Title == "C# Advanced Topics");

            Console.WriteLine(singleBook.Title);
            Console.WriteLine(singleOrDefaultBook == null ? "null" : singleOrDefaultBook.Title);
            Console.WriteLine(firstBook.Title + " " + firstBook.Price);
            Console.WriteLine(firstOrDefaultBook == null ? "null" : firstOrDefaultBook.Title);
            Console.WriteLine(lastBook.Title + " " + lastBook.Price);

            Console.WriteLine("Paged Books:");
            var pagedBooks = books.Skip(2).Take(3);

            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title);
            }

            var count = books.Count();
            Console.WriteLine(count);

            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine(maxPrice);

            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(minPrice);

            var sumPrice = books.Sum(b => b.Price);
            Console.WriteLine(sumPrice);
        }
    }
}
