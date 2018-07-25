using System;
using System.Collections;
using System.Collections.Generic;

namespace DecisionMakingswitchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            char choice;
            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            loop:
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Do you want to continue Y/N ?");
            Console.Write("Enter the operation you want to do:");
            choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case '1':
                    result = num1 + num2;
                    Console.WriteLine("The result of addition is {0}", result);
                    break;
                case '2':
                    result = num1 - num2;
                    Console.WriteLine("The result of subtraction is {0}", result);
                    break;
                case '3':
                    result = num1 * num2;
                    Console.WriteLine("The result of Multiplication is {0}", result);
                    break;
                case '4':
                    result = num1 / num2;
                    Console.WriteLine("The result of Division is {0}", result);
                    break;
                case '5':
                    Console.WriteLine("Do you want to continue Y/N ?");
                    if (Console.ReadLine().ToUpper().Equals("N"))
                    {
                        System.Environment.Exit(0);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            goto loop;
            Console.ReadLine();


        }

    }
}