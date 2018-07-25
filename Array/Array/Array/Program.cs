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
            int[] n = new int[10];  // n is an array of 10 integers
            int i, j;
            for(i=1;i<10;i++)
            {
                n[i] = i + 10;

            }
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Elements:{0}={1}", j, n[j]);
            }
            Console.ReadKey();

        }
    }
}
