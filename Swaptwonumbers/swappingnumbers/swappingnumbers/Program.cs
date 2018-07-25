using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swappingnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("Enter a first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping the numbers: {0} {1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping numbers: {0} {1}",a,b);
            Console.ReadKey();
        }
    }
}
