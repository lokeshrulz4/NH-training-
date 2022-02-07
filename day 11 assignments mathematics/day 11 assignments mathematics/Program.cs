using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_11_assignments_mathematics
{
    class Mathematics
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return a - b;
        }

        public static int mul(int a, int b)
        {
            return a * b;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Add(1045, 1578));
            Console.WriteLine(Mathematics.sub(1007, 505));
            Console.WriteLine(Mathematics.mul(253, 2));

            Console.ReadLine();

        }
    }
}
