using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_evening5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
              int number,input;
        Console.WriteLine("enter the number");
            number =Convert.ToInt32(Console.ReadLine());
            for (input=1; input <=10; input++)
            {
                Console.WriteLine("{0} * {1} = {2}", number,input,(number * input));
            }
            Console.ReadLine();
            
        }
    }
}








