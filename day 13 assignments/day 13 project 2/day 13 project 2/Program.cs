﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_13_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 56, 67 }, { 84, 43 }, { 11, 22 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + "  ");
                }
                Console.Write("\n");

            }
            Console.ReadLine();

        }
    }
}
       
    

