using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_morning_overloadig
{
    class Algebra
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Algebra obj = new Algebra();
            Console.WriteLine(obj.add(87, 56));
            Console.WriteLine(obj.add(877, 67, 7));
            Console.WriteLine(obj.add(567, 645, 867, 9));

            Console.ReadLine();

        }
    }
}

