using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11_assignment_with_properties
{
    class Employee
    {
        private int id;
        private string name;
        private string designation;
        private int salary;

        public int Id { get; set; }


        public string Name { get; set; }

        public string Designation { get; set; }

        public int Salary { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 11001;
            Console.WriteLine($"id = {emp.Id}");
            emp.Name = "lokesh";
            Console.WriteLine($"name = {emp.Name}");
            emp.Designation = "testing";
            Console.WriteLine($"designation = {emp.Designation}");
            emp.Salary = 80000;
            Console.WriteLine(emp.Salary);
            Console.ReadLine();

        }
    }
}