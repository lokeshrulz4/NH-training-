using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_ASSIGNMENT_ON_STARS
{
    internal class Program
    {
        static void Main(string[] args)
            {

                Console.WriteLine("Enter no.of rows to be Printed:");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" * ");
                    }
                    Console.WriteLine();


                }


                Console.ReadLine();

            }




        }

    }



    

