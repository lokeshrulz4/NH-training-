using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8_asignment
{ 
    class Department
{
    public int id;
    public string name;
    public int empcount;
}

    internal class Program
    {
        static void Main(string[] args)
        {
            Department[] department = new Department[]
           {
                new Department(){ id = 1, name ="developer",empcount=51},
                new Department(){ id = 2, name ="back end",empcount =30},
                new Department(){ id = 3, name ="testing", empcount =100},
                new Department(){ id = 4, name ="sql developer", empcount=29},
                new Department(){ id = 5, name ="front end",empcount=(63)}
           };
           
            //empcount >50 using FORLOOP

            for (int i = 0; i < department.Length; i++)

            {
                if (department[i].empcount > 50)
                    Console.WriteLine($"id={department[i].id},name={department[i].name}");
            }
            
            // empcount >50 using FOREACH LOOP
            foreach (var e in department)
            {
                if (e.empcount > 50)
                    Console.WriteLine($"id={e.id},name={e.name}");
            }
            
            // empcount >50 using LAMBDA EXPRESSION
            department.ToList().Where(e => e.empcount > 50).ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name}"));
            


            // empcount >50 using LINQ query
            var result = from e in department
                         where e.empcount > 50
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name}"));




            Console.ReadLine();
        }
    }
}
        
    

