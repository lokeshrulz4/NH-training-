using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_morning_assignment
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { id = 1, name = "lokesh", salary = 8000 };
            Console.WriteLine($"id={emp.id},name={emp.name},Salary={emp.salary}");

            Console.ReadLine();
        }
    }
}
