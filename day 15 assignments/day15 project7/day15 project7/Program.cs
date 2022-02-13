using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15project7
{
    internal class Program
{
    static void Main(string[] args)
    {
        string sourceFile = @" D:\nadella\file assignments programs\\Hello";
        string destination = @" D:\nadella\file assignments programs\file\\Hello";
        File.Move(sourceFile, destination);
        Console.WriteLine("file moved");

        Console.ReadLine();

    }
}
}

