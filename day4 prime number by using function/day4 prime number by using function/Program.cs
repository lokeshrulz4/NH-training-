using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_prime_number_by_using_function
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter any number:");
            int input = Convert.ToInt32(Console.ReadLine());

            if (isPrimeNumber(input))
                Console.WriteLine("It is a PrimeNumber", input);
            else
                Console.WriteLine("It is not a PrimeNumber", input);
            Console.ReadLine();
        }
        static bool isPrimeNumber(int input)
        {

            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }


            return true;

        }
    }
}
