using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTPClasswork
{
    class Mtp


    {
        Random Rnd = new Random();


        int MAX_X = 79;
        int MAX_Y = 24;



        private int x;
        private int y;
        private char ch;
        private ConsoleColor fcolor;
        private enum Direction { up, upR, right, downR, down, downL, left, upL };
        private Direction dire;
        private int speed;
        private ConsoleColor bcolor;



        //בנאי
        public Mtp(int x, int y, char ch, ConsoleColor fcolor, int speed = 1)
        {
            this.x = x;
            this.y = y;
            this.ch = ch;
            this.fcolor = fcolor;
            this.speed = speed;
        }

        //קובעות
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void SetFcolor (ConsoleColor fcolor)
        {
            this.fcolor = fcolor;
        }
        public void SetBcolor (ConsoleColor bcolor)
        {
            this.bcolor = bcolor;
        }
        public void SetSpeed (int speed)
        {
            this.speed = speed;
        }
        public void SetChar (char ch)
        {
            this.ch = ch;
        }
        //מאחזרות
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public ConsoleColor GetFcolor()
        {
            return fcolor;
        }
        public ConsoleColor GetBcolor()
        {
            return bcolor;
        }
        public char GetChar()
        {
            return ch;
        }
        public int GetSpeed()
        {
            return speed;
        }



        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = fcolor;
            Console.WriteLine(ch);
            Console.ResetColor();
        }


        public void undraw()
        {
            Mtp other = new Mtp(this.x, this.y, ' ', ConsoleColor.Black, this.speed);
            other.draw();

        }



        public void MoveUp()
        {
            if (y - speed < 0)
                y -= speed;
            
        }

        public void MoveDown()
        {
            if (y + speed < MAX_Y)
                y += speed;
        }

        public void MoveRight()
        {
            if (x + speed < MAX_X)
                x += speed;
        }

        public void MoveLeft()
        {
            if (x - speed < 0)
                x -= speed;
        }

        public void MoveUpRight()
        {
            MoveUp();
            MoveRight();
        }

        public void MoveDownRight()
        {
            MoveDown();
            MoveRight();
        }
        public void MoveUpLeft()
        {
            MoveUp();
            MoveLeft();
        }

        public void MoveDownLeft()
        {
            MoveDown();
            MoveLeft();
        }



        public void ReverseDirection()
        {
            dire = (Direction)(((int)dire + 4) % 8);
        }


        public void MoveDirection()
        {
            if (this.dire == Direction.up)
                MoveUp();
            if (this.dire == Direction.down)
                MoveDown();
            if (this.dire == Direction.left)
                MoveLeft();
            if (this.dire == Direction.right)
                MoveRight();
            if (this.dire == Direction.upL)
                MoveUpLeft();
            if (this.dire == Direction.upR)
                MoveUpRight();
            if (this.dire == Direction.downL)
                MoveDownLeft();
            if (this.dire == Direction.upL)
                MoveUpLeft();
        }


        public void MoveOneStep()
        {
            SetSpeed(1);
            MoveDirection();
        }


        public void RndMove()
        {
            if (Rnd.Next(1,101)<10)
            {
                this.dire = (Direction)Rnd.Next(1, 9);
                MoveOneStep();

            }
        }

        
        public bool Touch(Mtp other)
        {

        }


    }
}
