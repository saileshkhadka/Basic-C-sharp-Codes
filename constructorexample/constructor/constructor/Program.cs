using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
     class Program
    {
        int a, b;
       public Program()
        {
             a = 100;
             b = 200;
        }
         static void Main()
        {
            Program obj = new Program();
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.Read();
        }
    }
}
