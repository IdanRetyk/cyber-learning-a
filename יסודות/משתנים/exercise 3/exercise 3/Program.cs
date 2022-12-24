using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            int num2 = 2;
            num1 += num2;
            Console.WriteLine($"num1 = {num1} num2 = {num2}");
            num2 -= 5;
            Console.WriteLine($"num1 = {num1} num2 = {num2}");
            num2 = num1 + 1;
            Console.WriteLine($"num1 = {num1} num2 = {num2}");



        }
    }
}
