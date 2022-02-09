using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data =new int[2, 2];
            data[0, 0] = 34;
            data[0, 1] = 69;
            data[1, 0] = 984;
            data[1, 1] = 124;


            for (int i = 0; i < 2; i++)
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
        
    

