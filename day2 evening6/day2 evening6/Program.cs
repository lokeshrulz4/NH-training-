﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_evening6
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int num;
        Console.WriteLine("enter the number :");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=10;i++)
            {
           Console.WriteLine("{0} *{1} ={2}" ,num,i,num * i);
    }
    Console.ReadLine();
       }
}
}

