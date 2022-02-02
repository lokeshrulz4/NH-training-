using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            // using for loop
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] % 2 == 0)
                    Console.WriteLine(data[i]);
            }

            // using forach loop
            foreach (var d in data)
            {
                if (d % 2 == 0)
                    Console.WriteLine(d);
            }

            // using lamda expression
            data.Where(d => d % 2 == 0).ToList().ForEach(d => Console.WriteLine(d));

            // using LINQ Query
            var result = from d in data
                         where d % 2 == 0
                         select d;
            result.ToList().ForEach(d => Console.WriteLine(d));

            Console.ReadLine();


        }
    }
}
        
    

