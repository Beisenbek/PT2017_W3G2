using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    
    class Program
    {
        static int Sum(int value, int limit)
        {
            if (value > limit) return 0;
            return value + Sum(value + 1, limit);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(0, 100));
        }
    }
}
