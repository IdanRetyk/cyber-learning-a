using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            int grade = 0;
            while (grade != -1)
            {
                Console.WriteLine("Enter your grade");
                grade = int.Parse(Console.ReadLine());
                if (grade > 80)
                {
                    count++;
                    sum += grade;
                }

            }
            if (count == 0)
                Console.WriteLine("no avergae");
            else
                Console.WriteLine($"average = {(double)sum/count}");
        }
    }
}
