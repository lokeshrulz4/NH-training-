using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_project_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[3][];
            names[0] = new char[] { 'l', 'K' };
            names[1] = new char[] { 'l', '0', 'k', 'e', 's', 'h', 'n' };
            names[2] = new char[] { 'S', 'i', 'v', 'a',  };


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < names[i].Length; j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.Write("\n");
                Console.ReadLine();
            }
        }
    }
}
      
    

