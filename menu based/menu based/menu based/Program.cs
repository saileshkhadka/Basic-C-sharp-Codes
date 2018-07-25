using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_based
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            int add = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;
            int mod = num1 % num2;
            Console.WriteLine("Addition:{0}+{1}={2}", num1, num2, add);
            Console.WriteLine("subtraction:{0}-{1}={2}", num1, num2, sub);
            Console.WriteLine("multiplication:{0}*{1}={2}", num1, num2, mul);
            Console.WriteLine("Division:{0}/{1}={2}", num1, num2, div);
            Console.WriteLine("modulus:{0}%{1}={2}", num1, num2, mod);
            Console.ReadKey();
        }
    }
}
