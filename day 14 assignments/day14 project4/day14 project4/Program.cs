﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14_project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i <= 1097; i++)
            {
                if (i % 97 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}



                    

