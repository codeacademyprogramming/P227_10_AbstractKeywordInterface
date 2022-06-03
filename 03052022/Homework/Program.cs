using System;
using HomeworkClassLibrary;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department itDep = new Department()
            {
                EmployeeLimit = 5,
                SalaryLimit = 20000,
                Name = "IT"
            };

            Employee emp1 = new Employee
            {
                Name = "Tuncay",
                Surname = "Nesibli",
                Salary = 255
            };

            Employee emp2 = new Employee
            {
                Name = "Eli",
                Surname = "Salehov",
                Salary = 850
            };

            Employee emp3 = new Employee
            {
                Name = "Xeyal",
                Surname = "Memmedzade",
                Salary = 350
            };

            Employee emp4 = new Employee
            {
                Name = "Hikmet",
                Surname = "Abbasov",
                Salary = 19500
            };

            itDep.AddEmployee(emp1);
            itDep.AddEmployee(emp2);
            itDep.AddEmployee(emp3);
            itDep.AddEmployee(emp4);




            foreach (var item in itDep.Employees)
            {
                Console.WriteLine(item.Name +" - "+item.Salary);
            }
        }
    }
}
