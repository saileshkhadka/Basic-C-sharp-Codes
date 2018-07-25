using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class Program
    {
        public static int add(int add1,int add2)
        {
            return(add1 + add2);
        }
        public static int multiply(int mul1,int mul2)
        {
            return (mul1 * mul2);
        }
        public static int sub(int sub1,int sub2)
        {
            return (sub1 - sub2);
        }
        public static int result(int a,int b, int c, int d)
        {
            return ((a + b) - (c * d));
        }
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter the value of a:");
            int a1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b:");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of c:");
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of d:");
            int d1 = Convert.ToInt32(Console.ReadLine());

            int result = Program.result(a1, b1, c1, d1);
            Console.WriteLine(result);

            int add1 = add(a1, b1);
            int mul1 = multiply(c1, d1);

            int x2 = sub(add1, mul1);
            Console.WriteLine(x2);

            int x = sub(add(a1, b1), multiply(c1, d1));
            Console.WriteLine(x);

            Console.ReadKey();
        }
        
    }
}
