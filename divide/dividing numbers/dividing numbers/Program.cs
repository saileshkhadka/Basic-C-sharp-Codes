using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dividing_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, div;
            Console.WriteLine("Enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a / b);
            
            Console.ReadKey();
        }
    }
}
