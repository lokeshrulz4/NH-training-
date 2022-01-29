using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_prime_numbers_in_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");

            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            int input2 = Convert.ToInt32(Console.ReadLine());

            for (int i = input1; i <= input2; i++)
            {
                isPrime(i);

            }


            Console.ReadLine();
        }

        static void isPrime(int input)
        {
            bool isPrimenum = true;
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    isPrimenum = false;


                }

            }
            if (isPrimenum == true)
            {
                Console.WriteLine(input);
            }


        }
    }


}
    

