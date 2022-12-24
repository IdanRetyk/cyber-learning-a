using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace שבע_בום
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int num = 1; num < 999; num++)
            //{

            //bool digit1 = num % 10 == 7;
            //bool digit2 = num / 10 % 10 == 7;
            //bool digit3 = num / 100 == 7;
            //bool mod7 = num % 7 == 0;
            //if (digit1|| digit2 || digit3  || mod7)
            //{
            //    Console.WriteLine("BOOM");
            //}
            //else
            //{
            //    Console.WriteLine(num);
            //}
            ////wait some time
            //for (int i = 0; i < 99999999; i++)
            //{
            //    i++;
            //}


            //}
            for (int num = 1; num < 7777777; num++)
            {
                int boomTotal = (num % 7 == 0 ? 1 : 0) + 
                    num.ToString().Count(lett => lett == '7');


                //if (boomTotal == 0)
                //{
                //    Console.WriteLine(num);
                //}
                //else
                {
                    IEnumerable<string> booms = Enumerable.Repeat("BOOM", boomTotal);

                    Console.WriteLine(booms.Any() ? booms.Aggregate((x, y) => $"{x} {y}") : num.ToString());
                }

                //Thread.Sleep(100);

                //if (boomTotal == 0)
                //{
                //    Console.WriteLine(num);
                //}
                //if (boomTotal == 1)
                //{
                //    Console.WriteLine("BOOM");
                //}
                //if (boomTotal == 2) 
                //{
                //    Console.WriteLine("BOOM BOOM");

                //}
                //if (boomTotal == 3)
                //{
                //    Console.WriteLine("BOOM BOOM BOOM");
                //}
                //if (boomTotal == 4) 
                //{
                //    Console.WriteLine("BOOM BOOM BOOM BOOM");
                //}
            }

            Console.ReadKey();
            //int fuckoff = 587;
            //foreach (char lett in fuckoff.ToString())
            //{
            //    Console.WriteLine(lett);
            //}
        }  
	
    }
}
