using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mone_and_tzover_classwork
{
    class Program
    {
        public static void ex1()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter two numbers");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                if (num1 % 2 == num2 % 2)
                    sum += (num1 + num2);
                
            }
            Console.WriteLine($"sum = {sum}");
        }
        
        public static void ex2()
        {
            int didAll = 0;
            int didSome = 0;
            int raz = 0;
            Console.WriteLine("how many tasks?");
            int tasks = int.Parse(Console.ReadLine());
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("how many tasks did the student did?");
                int num = int.Parse(Console.ReadLine());
                if (tasks == num)
                    didAll++;

            }
        }
        public static void ex7()
        {
            int biggest = int.MinValue;
            int smallest = int.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
                biggest = Math.Max(biggest, num);
                smallest = Math.Min(smallest, num);
            }
            Console.WriteLine($"biggest = {biggest}, smallest = {smallest}");
        }

        public static void ex9()
        {
            int countEverything = 0;
            int countTwo = 0;
            int countMoreThan3 = 0;
            int countMoreTrips = 0;
            for (int i = 0; i < 6 ; i++)
            {
                Console.WriteLine("How many trips?");
                int trips = int.Parse(Console.ReadLine());
                Console.WriteLine("How many parties?");
                int par = int.Parse(Console.ReadLine());
                Console.WriteLine("How many mvoies?");
                int mov = int.Parse(Console.ReadLine());
                if ((trips > 0) && (mov > 0) && (par > 0)) //כולם
                    countEverything++;

                else if (trips>0)//שתיים בדיוק
                {
                    if ((par > 0) || (mov > 0))
                        countTwo++;

                }
                else if(!(trips > 0) && (mov > 0) && (par > 0))
                {
                    if ((par > 0) && (mov > 0))
                        countTwo++;
                }

                if ((trips > 3) || (mov > 3) || (par > 3)) //יותר משלוש באחד מהם
                    countMoreThan3++;

                if (trips > par)
                    countMoreTrips++;

            }
            Console.WriteLine($"The amount of students who did everything is {countEverything}\n" +
                $"The amount of students who did exactly two is {countTwo} \n" +
                $"The amount of students who did more than three in one of them {countMoreThan3}\n" +
                $"The amount of students who did more trips than parties is {countMoreTrips}" );
        }
        static void Main(string[] args)
        {
            ex1();
        }
    }
}
