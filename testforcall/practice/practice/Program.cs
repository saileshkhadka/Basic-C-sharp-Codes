using practice.program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter the value of x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. sub");
            Console.WriteLine("3. multiplication");
            Console.WriteLine("4. division");
            Console.WriteLine("5. modulus");

            int test = Convert.ToInt32(Console.ReadLine());
            Calcualtor calc = new Calcualtor();
            while (true)
            if(test==1)
            {
                Console.WriteLine(calc.add(x, y));
            }
            else if (test==2)
            {
                Console.WriteLine(calc.sub(x, y));
            }
            else if (test==3)
            {
                Console.WriteLine(calc.multiplication(x, y));
            }
            else if(test==4)
            {
                Console.WriteLine(calc.division(x, y));
            }
            else
            {
                Console.WriteLine(calc.mod(x, y));
            }
            Console.ReadKey();
        }
    }
}
