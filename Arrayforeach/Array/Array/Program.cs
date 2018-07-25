using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; //n is an array of 10 integers
            int i;

            for (i = 0; i < 10; i++)
            {
                n[i] = i + 10;
            }
            foreach (int x in n)
            {
                 i = x - 10;
                Console.WriteLine("Elements: {0}={1}",i,x);
            }
            Console.ReadKey();
        }
    }
}
