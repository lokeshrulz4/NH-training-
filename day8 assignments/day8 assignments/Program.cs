using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//****************
//AUTHOR:lokesh nadella
//purpose:print employee id ,salary,name
//****************

namespace day8_assignments
{
    
    class Employee
    {
        public int Id;
        public string Name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 101, Name = "lokesh", salary = 15000 },
                new Employee() { Id = 102, Name = "sanjay", salary = 10000 },
                new Employee() { Id = 103, Name = "siva", salary = 20000 },
                new Employee() { Id = 104, Name = "pavan", salary = 30000 },
                new Employee() { Id = 105, Name = "chandra", salary = 40000 },
            };
            // create employees using FOR LOOP
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"id={employees[i].Id},name={employees[i].Name}, salary={employees[i].salary}");

            }
            Console.WriteLine("*******");
            // create employeees using FOREACH LOOP
            foreach (var e in employees)
            {
                Console.WriteLine($"id ={e.Id}, name={e.Name}, salary={e.salary}");
            }
            Console.WriteLine("********");
            // create employees using LAMBDA EXPRESSION
            employees.ToList().ForEach(e => Console.WriteLine($"id{e.Id}, name={e.Name}, salary={e.salary}"));
            Console.WriteLine("*******");
            // create employees using LINQ QUERY
            var result = from e in employees
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"id{e.Id},name={e.Name},salary={e.salary}"));

            Console.ReadLine();

        }
    }
}
        
    

