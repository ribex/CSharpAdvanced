using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very very very long blog post...";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);

            // use existing extension method
            IEnumerable<int> numbers = new List<int>() {1, 5, 2, 3, 10, 2, 18};
            var max = numbers.Max();
            Console.WriteLine(max);

        }
    }
}
