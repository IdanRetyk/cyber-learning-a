using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diconstruct_number
{
    class Program
    {
        public static void ex1()
        {
            int sum = 0;
            Console.WriteLine("Enter length");
            int leng = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < leng; i++)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
        public static void ex2()
        {
            int sum = 0;
            Console.WriteLine("Enter num");
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }

        public static void ex3()
        {
            int num, savenum = 1;
            int maxsum = int.MinValue;
            int biggest = 0;
            while (savenum >= 0)
            {
                Console.WriteLine("Enter number");
                num = int.Parse(Console.ReadLine());
                savenum = num;
                int sum = 0;
                while (num != 0)//מפרק את נאם לסכום ספרותיו
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum > maxsum)
                {
                    maxsum = sum;
                    biggest = savenum;
                }
            }
            Console.WriteLine(biggest);
        }

        public static void ex4()
        {
            int longest = 0;
            Console.WriteLine("Enter char");
            char ch = char.Parse(Console.ReadLine());
            char prech = '0';
            int currLeng = 0;
            while (ch != '%')
            {
                if (ch == prech)
                    currLeng++;
                else
                    currLeng = 1;

                if (currLeng > longest)
                    longest = currLeng;

                prech = ch;
                
                ch = char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"longest streak = {longest} and the streak is {);



        }


        static void Main(string[] args)
        {
            ex4();

        }
    }
}
