using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actionClasswork
{
    class Program
    {
        public static int digSum(int num)
        {
            int notNum = num;
            int sum = 0;
            while (notNum != 0)
            {
                sum += notNum % 10;
                notNum /= 10;

            }
            return sum;
        }


        public static int amoutOfevens(int num)
        {
            int count = 0;
            while (num != 0)
            {
                if ((num % 10) % 2 == 0)
                    count++;
                num /= 10;
            }
            return count;
        }



        public static int factorial(int num)
        {
            int mul = 1;
            for (int i = 2; i <= num; i++)
            {
                mul *= i;
            }
            return mul;
        }


        public static bool prime(int num)
        {
            for (int i = 2; i <= (int)Math.Sqrt(num); i++)
            {
                if (num % i == 0 && num != 2)
                    return false;
                
            }
            return true;
        }

        
        static void Main(string[] args)
        {

           //ex0
           Console.WriteLine("Enter two numbers");
           int numA = int.Parse(Console.ReadLine());
           int numB = int.Parse(Console.ReadLine());
           if (digSum(numA  ) > digSum(numB))
              Console.WriteLine(numA);
           else
               Console.WriteLine(numB);
           Console.ReadKey();
           
           //ex1
           Console.WriteLine("Enter number");
           int num1 = int.Parse(Console.ReadLine());
           Console.WriteLine(amoutOfevens(num1));
           
           //ex2
           Console.WriteLine("Enter a number");
           int num2 = int.Parse(Console.ReadLine());
           Console.WriteLine(factorial(num2)); 
           
            //ex3
            Console.WriteLine("Enter number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(prime(num3));


        }

    }
}
