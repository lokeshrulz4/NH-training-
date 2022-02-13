using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//********************************************
//Author:lokesh nadella
//Purpose: creation of files
//************************************************
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            File.WriteAllText("D:\\nadella\\file assignments programs\\Hello.txt", "Hello world");
            Console.WriteLine("file created");
            Console.ReadLine();
        }
    }
}
