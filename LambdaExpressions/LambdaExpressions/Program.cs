using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            // args => expression

            // () => ...
            // x => ...
            // (x, y, z) => ...

            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));   // 25


            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);

            Console.WriteLine(result); // 50

            var books = new BookRepository().GetBooks();

//            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            var cheapBooks = books.FindAll(book => book.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
            
        }

//        static bool IsCheaperThan10Dollars(Book book)
//        {
//            return book.Price < 10;
//        }
    }
}
