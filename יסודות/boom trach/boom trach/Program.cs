using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boom_trach
{
    class Program
    {
        static void Main(string[] args)
        {
            //אתגר 1
            int nonBoomAmount = 0;
            //אתגר 2
            double average = 0;
            for (int i = 1; i <= 150; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                        Console.WriteLine("BOOM TRACH" + i);
                    else
                        Console.WriteLine("BOOM" + i);
                    average += i;
                }
                else if (i % 5 == 0)
                { 
                    Console.WriteLine("TRACH" + i);
                    average += i;
                }
                //אתגר 1
                else
                {
                    nonBoomAmount++;
                }
            }
            //אתגר 1 
            Console.WriteLine("amount of numbers who didnt triggter BOOM or TRACH:" +nonBoomAmount);
            //אתגר 2 
            Console.WriteLine("The avrage is" + (average/nonBoomAmount));
        }
    }
}
