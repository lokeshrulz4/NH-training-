using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_salary_assignment
{
    internal class Program
    {
        class Employee
        {
            public int id;
            public string name;
            public int salary;
        }
        internal class employee
        {
            static void Main(string[] args)
            {
                Employee[] employees = new Employee[]
                    {
                    new Employee() { id = 1, name ="john", salary =30000},
                    new Employee() { id = 2, name ="prasad",salary=25000},
                    new Employee() { id = 3, name ="sai",salary=10000},
                    new Employee() { id = 4, name ="uday",salary=64000},
                    new Employee() { id = 5, name ="jp",salary=40000}
                    };
                //using for loop
                for (int i = 0; i < employees.Length; i++)
                {
                    Console.WriteLine($"id={employees[i].id},name={employees[i].id},salary={employees[i].id}");
                }

                //using foreach
                foreach (var e in employees)
                {
                    Console.WriteLine($"id={e.id},name={e.name},salary{e.salary}");
                }

                //using lamda expression
                employees.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},salary{e.salary}"));
                Console.ReadLine();
            }
        }
    }
}
