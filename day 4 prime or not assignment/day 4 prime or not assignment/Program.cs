using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4_prime_or_not_assignment{
 
    
        internal class Program
        {

            static void Main(string[] args)
            {
                int input, i, count = 0;
                Console.WriteLine("Enter any number:");
                input = Convert.ToInt32(Console.ReadLine());

                for (i = 1; i <= input; i++)
                {
                    if (input % i == 0)
                        count++;
                }
                if (count == 2)
                    Console.WriteLine("It is a prime number", input);
                else Console.WriteLine("It is not a prime number", input);
                Console.ReadLine();
            }
        }
    }



    

