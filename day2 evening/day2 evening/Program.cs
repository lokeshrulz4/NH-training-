﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_evening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, n;
            Console.WriteLine("enter the n number");
            n = int.Parse(Console.ReadLine());
            {
                for (i = 0; i <= n; i++)
                    sum = sum + i;
            }
            Console.WriteLine("sum of n numbers:" + sum);
            Console.ReadLine();
        }
    }
}

                   
       
 
    

