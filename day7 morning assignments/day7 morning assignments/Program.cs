using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_morning_assignments
{

    class Employee
    {
        public int Id;
        public string Name;
        public int salary;

        public void ReadEmployee()
        {
            Console.WriteLine("Enter ID: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());

        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Id = {Id}, Name = {Name}, Salary = {salary}");
        }


    }
    internal class program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ReadEmployee();
            emp1.PrintEmployee();

            Console.ReadLine();

        }
    }
}
    

        
    

