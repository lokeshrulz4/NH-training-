using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*************************************
//Author:lokesh nadella
//Purpose:creation of files
//*****************************************

namespace day15pro8
{ 
    internal class Program
    {
       static void Main(string[] args)
       {
        Console.WriteLine(File.GetLastAccessTime("D:\\nadella\\file assignments programs\\file\\hello"));
        Console.ReadLine();
       }
     }
}

