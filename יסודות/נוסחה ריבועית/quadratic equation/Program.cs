using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value for a, b anc c (separed by enter)");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double delta = (b * b) - (4 * a * c);
            //Console.WriteLine($"delta = {delta}");
            

            if (delta >= 0)
            {
                double answer1 = (-b + Math.Sqrt(delta)) / 2 * a;
                double answer2 = (-b - Math.Sqrt(delta)) / 2 * a;
                if (answer1 == answer2)
                {
                    Console.WriteLine($"x = {answer1}");
                }
                else
                {
                    Console.WriteLine($"x1 = {answer1} \nx2 = {answer2}");
                }
                
            }
            else
            {
                delta = -delta;
                
                Console.WriteLine($"x1 = {(double)(-b) / (2 * a)} + {Math.Sqrt(delta) / 2 * a}i");
                Console.WriteLine($"x2 = {(double)(-b) / (2 * a)} - {Math.Sqrt(delta) / 2 * a}i");
            }
            
        }
    }
}
