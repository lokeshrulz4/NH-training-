using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4_assignment_on_sum
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
                rev = rev + rem;
            }

            Console.WriteLine("The Sum of Numbers is: " + rev);


            Console.ReadLine();


        }
    }

}


        

    


    

