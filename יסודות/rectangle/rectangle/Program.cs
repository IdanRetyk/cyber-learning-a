using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace rectangle
{
    class Program
    {

        public static void PrintRec(int x = 0, int y =0, int height = 10, int width = 10, ConsoleColor color = ConsoleColor.White)
        {
            ConsoleColor preColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(x, y+ i);

                for (int j = 0; j < width;j++)
                {
                    Console.Write("█");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = preColor;
        }



        public static void DelRec(int x = 0, int y = 0, int height = 10, int width = 10)
        {
            Console.SetCursorPosition(x, y);
            PrintRec(x, y, height, width, ConsoleColor.Black);
        }


        public static void MovRecR(int x = 0, int y = 0, int height = 10, int width = 10, ConsoleColor color = ConsoleColor.White)
        {
            PrintRec(x, y, height, width, color);
            Thread.Sleep(1000);
            DelRec(x, y, height, 1);
            PrintRec(x + width, y, height, 1, color);
        }

        public static void MovRecL(int x = 0, int y = 0, int height = 10, int width = 10, ConsoleColor color = ConsoleColor.White)
        {
            PrintRec(x, y, height, width, color);
            Thread.Sleep(1000);
            DelRec(x + width -1, y, height, 1);
            PrintRec(x - 1, y, height, 1, color);
        }



        public static void MovRecD(int x = 0, int y = 0, int height = 10, int width = 10, ConsoleColor color = ConsoleColor.White)
        {
             
            PrintRec(x, y, height, width, color);
            Thread.Sleep(1000);
            DelRec(x, y, 1, width);
            PrintRec(x , y + height, 1, width, color);
        }


        public static void MovRecU(int x = 0, int y = 0, int height = 10, int width = 10, ConsoleColor color = ConsoleColor.White)
        {

            PrintRec(x, y, height, width, color);
            Thread.Sleep(1000);
            DelRec(x, y + height -1, 1, width);
            PrintRec(x, y -1 , 1, width, color);
            Console.SetCursorPosition(0, y +height);
        }

        static void Main(string[] args)
        {
            MovRecU(5,10,10,7,ConsoleColor.Blue);
            
        }
    }
}
