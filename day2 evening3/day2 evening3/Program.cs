using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_evening3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("enter the number");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("FACTORS");
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}

        
    

