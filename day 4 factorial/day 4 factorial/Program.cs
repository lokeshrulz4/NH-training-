using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace day_4_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i,fact = 1;
            Console.WriteLine("enter any number :");
            input = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= input; i++) ;
            fact = fact * i;
            Console.WriteLine("factorial of a number :" + fact);
            Console.ReadLine();
        }
    }
}

       
        
   

