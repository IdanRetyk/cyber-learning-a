using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forfor
{
    class Program
    {
        public static void ex1()
        {
            char ch = '*';
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine("");
            }

        }

        public static void ex2()
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }
        }

        public static void ex3()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }


        public static void ex4()
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 5; j > 0; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }

        public static void ex5()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    Console.Write(i+j);
                }
                Console.WriteLine("");
            }
        }

        public static void ex6()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        public static void ex7()
        {
            for(int i = 1; i < 6; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }
        }

        public static void ex8()
        {
            for(int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i ; j++)
                {
                    Console.Write(j+i);
                }
                Console.WriteLine("");
            }
        }

        public static void ex9()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 5; j >=0; j--)
                {
                    Console.Write(j);

                }
                Console.WriteLine("");
            }
        }

        static void Main(string[] args)
        {
            ex9();
        }
    }
}
