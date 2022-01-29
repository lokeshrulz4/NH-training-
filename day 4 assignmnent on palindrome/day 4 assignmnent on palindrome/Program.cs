using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4_assignmnent_on_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m, rem, rev = 0;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;
            }
            if (n == rev)
                Console.WriteLine("Given numbr is palindrome");
            else
                Console.WriteLine("Given numbr is not a palindrome");

            Console.ReadLine();


        }
    }

}


       
    

