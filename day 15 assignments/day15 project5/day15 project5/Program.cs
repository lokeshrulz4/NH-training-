using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*********************************************
//Author:lokesh nadella
//Purpose:creation of files
//************************************************

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.GetLastWriteTime("D:\\nadella\\file assignments programs" +
                ""));
            Console.ReadLine();
        }
    }
}
