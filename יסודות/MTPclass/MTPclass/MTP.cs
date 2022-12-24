using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTPclass
{
    class MTP

    {
        private int x;
        private int y;
        private char ch;
        private ConsoleColor fcolor;
        private enum Direction { up, upR, right, downR, down, downL, left, upL };
        private Direction direction;
        private int speed;
        private ConsoleColor bcolor;



        //בנאי
        public MTP(int x, int y, char ch, ConsoleColor fcolor, int speed)
        {
            this.x = x;
            this.y = y;
            this.ch = ch;
            this.fcolor = color;
            this.speed = speed;
        }


        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = bcolor;
            Console.ForegroundColor = fcolor;
            Console.WriteLine(ch);
            Console.ResetColor();
        }


        public void undraw()
        {
            MTP other = new MTP(this.x,this.y,' ', ConsoleColor.Black, this.speed);
            other.draw();

        }


    }
}
