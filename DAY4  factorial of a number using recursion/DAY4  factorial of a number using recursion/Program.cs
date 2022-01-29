using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4__factorial_of_a_number_using_recursion
{
    internal class Program
    { 
            static void Main(string[] args)
            {

                Console.WriteLine("Enter any number:");
                int input = Convert.ToInt32(Console.ReadLine());

                int factorial = getFact(input);

                Console.WriteLine("factorial value is: " + factorial);

                Console.ReadLine();
            }
            static int getFact(int input)
            {

                if (input == 0)
                    return 1;
                else
                    return input * getFact(input - 1);
            }




        }
    }



   

