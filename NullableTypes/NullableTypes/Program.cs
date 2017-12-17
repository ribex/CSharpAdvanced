using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // this does not work:
            // DateTime cannotBeNull = null;

            // these are equivalent:
            Nullable<DateTime> date = null;
            DateTime? anotherDate = null;

            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            // Console.WriteLine("Value: " + date.Value); // throws exception

            DateTime? todaysDate = new DateTime(2017, 12, 17);
            // DateTime date2 = todaysDate; // will not compile
            DateTime date2 = todaysDate.GetValueOrDefault();
            Console.WriteLine(date2);

            DateTime? date3 = date2;
            Console.WriteLine(date3.GetValueOrDefault());

            DateTime? nullDate = null;
            DateTime date4;

            if (nullDate != null)
                date4 = date.GetValueOrDefault();
            else
            {
                date4 = DateTime.Today;
            }
            Console.WriteLine("date4: " + date4);

            // same as above conditional and similar to ternary operator
            // null coalescing operator
            DateTime date5 = nullDate ?? DateTime.Today;
            Console.WriteLine("date5: " + date5);

        }
    }
}
