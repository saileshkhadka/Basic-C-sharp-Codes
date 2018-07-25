using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            int result;
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the seconf number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            result = num1 * num2 * num3;
            Console.WriteLine("{0}*{1}*{2}={3}", num1, num2, num3,result);
            Console.ReadKey();
        }
    }
}
