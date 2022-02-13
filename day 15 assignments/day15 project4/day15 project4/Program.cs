using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***************************************
//Author:lokesh nadella
//Purpose: file copy
//***************************************

namespace day15project4
{
    internal class Program
{
    static void Main(string[] args)
    {
        File.Copy("D:\\nadella\\file assignments programs\\Hello", "D:\\nadella\\copy folder\\Hello");
        Console.WriteLine("File created");
        Console.ReadLine();
    }
}
}


