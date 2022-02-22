using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;

namespace BusinessLogicLibrary
{
    public class EmployeeBll
    {
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            var result = EmployeeDAL1.AddEmployee(empId, empName, empSalary, empAge);


            return result;
        }
        public static List<string> GetEmployeeById(int id)
        {
            var result = EmployeeDAL1.GetEmployeeById(id);
            return result;
        }
        public static List<string> GetEmployeeByname(string name)
        {
            var result = EmployeeDAL1.GetEmployeeByname(name);
            return result;
        }
        public static string[] GetallEmployees()
        {
            var result = EmployeeDAL1.GetallEmployees();
            return result;
        }
    }
}