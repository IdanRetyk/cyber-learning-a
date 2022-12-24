using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nastedloop_page2
{
    class Program
    {


        public static void ex1()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Amount of people on the plane");
                int people = int.Parse(Console.ReadLine());//כמות אנשים על כל מטוס
                int totalLegg = 0; //סך המזוודות על כל מטוס 
                int totalTotalLegg = 0; //סך המזוודות על כל המטוסים
                for (int j = 0; j < people; j++)
                {
                    Console.WriteLine("Amount of suitcases");
                    int legg = int.Parse(Console.ReadLine());
                    totalLegg += legg;
                }
                double average = (double)totalLegg / people;
                Console.WriteLine($"total leggage on this plane is {totalLegg}"); //א
                Console.WriteLine($"average = {average}");//ב
            }

           
        }
        static void Main(string[] args)
        {
            ex1();
        }
    }
}
