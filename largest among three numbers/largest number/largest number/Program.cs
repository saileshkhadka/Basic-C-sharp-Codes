using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The first number is greater");
                }
                else
                {
                    Console.WriteLine("The third number is greatest");
                }
            }
            else if (num2 > num3)
                {
                    Console.WriteLine("The second numnber is greater");
                }
            else
            {
                Console.WriteLine("The third number is greater");
            }

            Console.ReadKey();
        }
    }
}
