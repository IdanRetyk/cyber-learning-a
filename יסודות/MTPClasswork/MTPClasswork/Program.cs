using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MTPClasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            Mtp pixel = new Mtp(0, 0, '█', ConsoleColor.Green, 2);
            pixel.draw();
            Thread.Sleep(1000);
            pixel.undraw();
        }
    }
}
