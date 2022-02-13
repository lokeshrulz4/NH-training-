

            using System;
            using System.Collections.Generic;
            using System.IO;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace ConsoleApp5
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string curFile = @" D:\\nadella\\file assignments programs\\Hello";

                Console.WriteLine(File.Exists("D:\\nadella\\file assignments programs\\Hello") ? "File exits" : "File deos not exits");


                Console.ReadLine();
            }
        }
    }



 
