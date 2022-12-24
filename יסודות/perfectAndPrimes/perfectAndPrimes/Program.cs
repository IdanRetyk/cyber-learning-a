using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfectAndPrime

{

    class Program
    {
        public static void ex1()
        {
            for (int i = 6; i < int.MaxValue; i += 2)
            {
                if ((i%100 == 6) || (i % 100 == 16) || (i % 100 == 28) || (i % 100 == 36) || (i % 100 == 56) || (i % 100 == 76) || (i % 100 == 96))
                {
                    int sum = 1;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                            sum += j;
                    }
                    if (sum == i)
                    {
                        Console.WriteLine(i + " is perfect");
                        Console.ReadLine();
                    }
                    

                }
                if (i%1000 == 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("done");
        }

        public static void ex2()
        {
            //Console.WriteLine("Enter your number");
            //int num = int.Parse(Console.ReadLine());
            for (int i = 1000000000; i < int.MaxValue; i++)
            {
                bool isPrime = true;
                for (int j = 2; (j < Math.Ceiling(Math.Sqrt(i))) && isPrime; j++)
                {
                    if (i % j == 0)
                        isPrime = false;
                }
                if ((isPrime) && (i != 4)) //ארבע הוא מקרה פרטי שהתוכנה מחשיבה אותו כראשוני בגלל שהיא לא נכנסת לתוך הפור, ואם מנסים לסדר את זה אז שתיים לא ראשוני בגלל שאיי וג'יי שווים
                    Console.WriteLine(i);
            }
        }

        public static void ex2a()
        {

            int count = 0;
            for (int i = 2; i < 1000; i++)
            {
                bool isPrime = true;
                for (int j = 2; (j < Math.Ceiling(Math.Sqrt(i))) && isPrime; j++)
                {
                    if (i % j == 0)
                        isPrime = false;
                }
                if ((isPrime) && (i != 4)) //ארבע הוא מקרה פרטי שהתוכנה מחשיבה אותו כראשוני בגלל שהיא לא נכנסת לתוך הפור, ואם מנסים לסדר את זה אז שתיים לא ראשוני בגלל שאיי וג'יי שווים
                    count++;
            }
            Console.WriteLine(count);
        }

        static void Main(string[] args)
        {
            ex2();
            Console.ReadLine();

        }

    }

}