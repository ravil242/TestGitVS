using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i %2 == 0)
                {
                    Console.WriteLine("чичо");
                }
            }
            int gash = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(gash);
            string name = "oleg";
        }
    }
}
