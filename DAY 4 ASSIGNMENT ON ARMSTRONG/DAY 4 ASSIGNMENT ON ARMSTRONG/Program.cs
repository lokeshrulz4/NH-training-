using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_ASSIGNMENT_ON_ARMSTRONG
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
                    if (getArmtrong(i))
                    {
                        Console.WriteLine(i);
                    }

                }


                Console.ReadLine();

            }

            static bool getArmtrong(int n)
            {
                int rem, m, res = 0;

                m = n;
                while (m > 0)
                {

                    rem = m % 10;
                    m /= 10;
                    res = res + rem * rem * rem;

                }
                return ((res == n) ? true : false);


            }


        }

    

}
    

