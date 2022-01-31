using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_3_list.@int
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int>data = new List<int>();
            int sum = 0;
            data.Add(35);
            data.Add(775);
            data.Add(90);
            foreach (var d in data)
            {
                sum = sum + d;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
        
    

