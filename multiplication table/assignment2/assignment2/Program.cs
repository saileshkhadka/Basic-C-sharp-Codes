using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter a number for its Multiplication Table:");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; ++i)
            {
                Console.WriteLine("{0}x{1}={2}", n, i, n * i);
            }
            Console.ReadKey();
        }
    }
}
