using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_sum_of_n_natural_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i, sum = 0;
            Console.WriteLine("enter any number :");
            input = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= input; i++)
                sum = sum + i;
            Console.WriteLine("sum of given natural number is :" + sum);
            Console.ReadLine();
        }
    }
}

        
       
    

