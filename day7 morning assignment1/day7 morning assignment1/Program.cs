using System;
using System.Linq;

namespace day7_morning_assignment1
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
                    new Employee() { id = 1, name ="lokesh", salary =30000},
                    new Employee() { id = 2, name ="mahesg",salary=25000},
                    new Employee() { id = 3, name ="sai",salary=10000},
                    new Employee() { id = 4, name ="sukesh",salary=64000},
                    new Employee() { id = 5, name ="siva",salary=40000}
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

    

