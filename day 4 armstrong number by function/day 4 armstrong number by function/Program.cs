using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4_armstrong_number_by_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, rem, m, res = 0;
            Console.WriteLine("Enter any number :");
            n = Convert.ToInt32(Console.ReadLine());
            getArmtrong(n);
            Console.ReadLine();
        }

        static void getArmtrong(int n)
        {
            int rem, m, res = 0;

            m = n;
            while (m > 0)
            {

                rem = m % 10;
                m /= 10;
                res = res + rem * rem * rem;

            }
            Console.WriteLine((res == n) ? "Armstrong" : "not Armstrong");


        }


    }

}

        
    

