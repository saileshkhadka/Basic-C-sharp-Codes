using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the first integer:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((num1 == 20 || num2 == 20) || (num1 + num2 == 20));
            Console.ReadKey();
        }
    }
}
