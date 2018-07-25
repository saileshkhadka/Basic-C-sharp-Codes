using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resultbased
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalMarks;
            float Percentage;
            int math, science, english, opt, nepali;
            string NameOfStudents, Grade;
            Console.WriteLine("Enter the name of student:");
            NameOfStudents = Console.ReadLine();

            Console.WriteLine("Enter the marks of Math:");
            math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of science:");
            science = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of English:");
            english = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of opt:");
            opt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of Nepali:");
            nepali = Convert.ToInt32(Console.ReadLine());

            TotalMarks = math + science + english + opt + nepali;
            Percentage = TotalMarks / 5;

            if (Percentage >= 80)
            {
                Grade = "A";

            }
            else if (Percentage >= 70 && Percentage < 80)
            {
                Grade = "B";
            }
            else if (Percentage >= 60 && Percentage < 70)
            {
                Grade = "c";
            }
            else
            {
                Grade = "F";
            }
            Console.WriteLine(" ");
            Console.WriteLine("****************-------------**********");
            Console.WriteLine("Name: " + NameOfStudents);
            Console.WriteLine(" ");
            Console.WriteLine("S.N  Subject                  Total Marks               Marks Obtained");
            Console.WriteLine("1.   Science                      100                        {0}", science);
            Console.WriteLine("2.   Math                         100                        {0}", math);
            Console.WriteLine("3.   English                      100                        {0}", english);
            Console.WriteLine("4.   opt                          100                        {0}", opt);
            Console.WriteLine("5.   nepali                       100                        {0}", nepali);
            Console.WriteLine("");
            Console.WriteLine("TotalMarks: " + TotalMarks);
            Console.WriteLine("Percentage: " + Percentage);
            Console.WriteLine("TotalMarks:{0}/{1}={3}", TotalMarks, 500, Percentage);
            Console.WriteLine("Grade: " + Grade);
            Console.ReadKey();
        }
    }
}
