using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomExs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool continue = true; //מתי לעצור את הפור
            int ans = rnd.Next(1, 11);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the numer");
                int guess = int.Parse(Console.ReadLine());
                if (guess == ans)
                {
                    Console.WriteLine("CORRECT");
                    continue = 
                }
            }

        }
    }
}
