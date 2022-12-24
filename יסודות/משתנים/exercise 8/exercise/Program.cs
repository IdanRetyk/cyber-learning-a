using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many minutes did Sharon used the website?");
            int minutes = int.Parse(Console.ReadLine());
            int total = minutes * 30;
            Console.WriteLine($"total price = {total}");
        }
    }
}
