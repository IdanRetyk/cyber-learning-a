using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiletirgul
{
    class Program
    {
        public static void ex3()
        {
            int num,savenum = 1;
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
        static void Main(string[] args)
        {
            ex3();
        }
    }
}
