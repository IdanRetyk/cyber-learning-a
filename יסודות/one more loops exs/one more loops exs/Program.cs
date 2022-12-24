using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_more_loops_exs
{
    class Program
    {
        public static void ex1()
        {
            Console.WriteLine("Enter a num");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1;  i<= num; i++)
            {
                if (num % i == 0)
                    Console.Write(i + ",");

            }
        }

        public static void ex2()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            string st = "1";
            int sum = 1;

            for (int i=2; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    st += " + " + i;
                }
            }

            if (num == sum)
                Console.WriteLine($"{num} is a perfect number {st} = {num}");
            else
                Console.WriteLine(num + " isn't a perfect number");

        }

        public static void ex3()
        {


            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());//קלט
            int sqr = ((int)Math.Sqrt(num)+1);//שורש של הקלט
            bool isPrime = true;//תנאי הרצה

            for (int i = 2; (i < sqr)&&(isPrime); i++)//בדיקה אם ראשוני
            {
                if (num % i == 0)
                    isPrime = false;
            }

            if (isPrime)
                Console.WriteLine(num + " is prime!");
            else
                Console.WriteLine(num + " is not prime D:");




        }

        




        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");
            //int num
            //for (int i = 2; i <= num; i++)
            //{

            //}
            ex3();
            
        }
    }
}
