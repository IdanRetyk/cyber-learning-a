using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exersice 1");
            
            Console.WriteLine("x =");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x1} {x1+1} {x1+2}");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("exersice 2");
            
            Console.WriteLine("x =");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("y =");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(x2*y2);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("exersice 3");

            Console.WriteLine("any number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(num3+2);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("exersice 4");

            Console.WriteLine("length");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("width");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine($"area = {length*width}, perimeter = {2*(length+width)}");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("exersice 5");

            Console.Write("enter amount of boys in class ");
            int boys = int.Parse(Console.ReadLine());
            Console.Write("enter amount of girls ");
            int girls = int.Parse(Console.ReadLine());
            int studentTotal = girls + boys;
            int dif = boys - girls;
            Console.WriteLine("total is: " + studentTotal);
            dif = Math.Abs(dif);
            Console.WriteLine("your difference is: " + dif);


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("exersice 6");

            Console.Write("enter amount of money ");
            double money = double.Parse(Console.ReadLine());
            double monSave = (money / 3) * 2;
            double monRest = (monSave / 4) * 3;
            Console.WriteLine("you saved " + monSave + "$");
            Console.WriteLine("you have " + monRest + " to spend");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("exersice 7");

            Console.Write("How many tickets sold ");
            int tickSell = int.Parse(Console.ReadLine());
            Console.Write("how much does a ticket cost");
            double tickCost = double.Parse(Console.ReadLine());
            double tickRev = tickSell * tickCost;
            double ticklost = (120 - tickSell) * tickCost;
            Console.WriteLine($"you made {tickRev}$");
            Console.WriteLine($"you lost {ticklost}$");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("exersice 8");

            Console.Write("how many days did you train this month ");
            int train = int.Parse(Console.ReadLine());
            Console.Write("enter how many meters is the pool ");
            int pool = int.Parse(Console.ReadLine());
            int swimonth = (pool * 10) * train;
            double swimonthkm = (double)swimonth / 1000;
            Console.WriteLine($"you swam {swimonth} m, or {swimonthkm} km");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("exersice 9");

            Console.Write("enter value of dollar in shekel ");
            double val = double.Parse(Console.ReadLine());
            Console.Write("enter how much dollars you have ");
            int bank = int.Parse(Console.ReadLine());
            double bankShekel = bank * val;
            Console.WriteLine($"you have {bankShekel} $");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("exersice 10");
            Console.Write("enter price of item");
            double priceitem = double.Parse(Console.ReadLine());
            double tax = priceitem * 0.18;
            Console.WriteLine($"with tax your price is {tax + priceitem}");
            Console.ReadKey();
        }
    }
}
