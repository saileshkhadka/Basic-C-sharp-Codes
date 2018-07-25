using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialnumber
{
    class Program
    {
        private static object n;

        public int factorial(int x)
        {
            int result;
            if(x==1)
            {
                return 1;
            }
            else
            {
                result = factorial(x - 1) * x;
                return result;
            }
            
        }
        static void Main(string[]args)
        {
            Program n = new Program();
            Console.WriteLine("factorial of 7 is {0}", n.factorial(7));
            Console.WriteLine("factorial of 8 is {0}", n.factorial(8));
            Console.ReadLine();
        }

    }
}
