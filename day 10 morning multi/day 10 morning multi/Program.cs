using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_morning_multi
{
    class Algebra
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
    }
    class TotalMaths : Algebra
    {
        public int mul(int a, int b)
        {
            return (a * b);
        }
    }
    class Allsubjects : TotalMaths
    {
        public string methane()
        {
            return "CH4";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Allsubjects obj = new Allsubjects();
            Console.WriteLine(obj.add(654, 98));
            Console.WriteLine(obj.sub(6543, 587));
            Console.WriteLine(obj.mul(513, 300));
            Console.WriteLine(obj.methane());
            Console.ReadLine();
            ;
        }
    }
}

        
    
