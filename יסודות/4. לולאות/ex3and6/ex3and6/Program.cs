using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3and6
{
    class Program
    {
        public static void ex3()
        {
            for (int i = 9; i <= 60; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine(i);
            }
        }

        public static void ex6()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(1.0/i);
            }
        }
        static void Main(string[] args)
        {
            ex3();
            ex6();
            Console.ReadKey();
        }
    }
}
