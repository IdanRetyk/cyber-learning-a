using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {

        public static void Ex6()
        {
            Circle circle1 = new Circle(10, ConsoleColor.DarkMagenta);
            circle1.Print();

            Circle circle2 = new Circle(3, ConsoleColor.Green);
            circle2.Print();

            circle1.SetColor(ConsoleColor.DarkRed);
            circle1.Print();

            circle2.SetRadius(4.5);
        }


        public static void Ex7()
        {
            Console.WriteLine("Enter Radius");
            int rad = int.Parse(Console.ReadLine());
            Circle circle1 = new Circle(rad, ConsoleColor.Yellow);
            circle1.Print();
        }


        static void Main(string[] args)
        {
            

                    

        }
    }
}
