
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***************************************
//Author:lokesh nadella
//Purpose: creation of files
//***************************************

namespace day15project13
{
    internal class Program
{
    static void Main(string[] args)
    {
            File.Copy("D:\\nadella\\file assignments programs\\hello", "D:\\nadella\\file assignments programs\\file\\quiz\\copy2");
            Console.WriteLine("File created");
        Console.ReadLine();
    }
}
}





