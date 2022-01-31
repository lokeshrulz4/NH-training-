          using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_assignment_on_loop_forloop_lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("lokesh");
            data.Add("mahesh");
            data.Add("suresh");
            data.Add("somesh ");
            data.Add("karesh");
            //values using for loop
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);
            }
            //values using for foreach loop
            foreach (var d in data)
            {
                Console.Write(d);
            }
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine(data[i]);
            }
            //values using lambda expresion
            data.ForEach(p => Console.WriteLine(p));
            Console.ReadLine();
        }
    }
}

               
            
        
    

