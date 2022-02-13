
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************
//Author:lokesh nadella
//purpose:create of files
//**************************************

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter Sr = new StreamWriter("D:\\nadella\\file assignments programs\\Hello", true);
            Sr.WriteLine("HI");
            Sr.WriteLine("i am ");
            Sr.WriteLine("Learning");
            Sr.WriteLine("c#");
            Sr.Close();
            Console.WriteLine("File done");
            Console.ReadLine();
        }
    }
}

