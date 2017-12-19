using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            dynamic d = i;

            long l = d;
        }
    }
}
