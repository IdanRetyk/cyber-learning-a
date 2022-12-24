using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many towels did Amir and his friends buy?");
            int towelAmount = int.Parse(Console.ReadLine());
            int total = towelAmount * 25;
            Console.WriteLine($"final price is {total}");
        }
    }
}
