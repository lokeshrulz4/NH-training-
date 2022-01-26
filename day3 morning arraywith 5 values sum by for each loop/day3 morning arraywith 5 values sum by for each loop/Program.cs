using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_morning_arraywith_5_values_sum_by_for_each_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[4];
            for (int i = 0; i <= data.Length; i++)
            {
                Console.WriteLine("enter number:");
                
                data[i] = Convert.ToInt32(Console.ReadLine());



            }
            Console.WriteLine("the numbers you entered are:");

            foreach (int d in data)
                Console.WriteLine(d);
        }
    }
}
        
    

