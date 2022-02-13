using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************
//Author:lokesh nadella
//purpose:creation of files
//**************************************

namespace day15project10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter Sr = new StreamWriter("D:\\nadella\\file assignments programs\\file\\Hello", true);
            Sr.WriteLine("HI");
            Sr.WriteLine("i am ");
            Sr.WriteLine("Lerning");
            Sr.WriteLine("c#");
            Sr.Close();
            Console.WriteLine("File done");
            Console.ReadLine();
        }
    }
}
