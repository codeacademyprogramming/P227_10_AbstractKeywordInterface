using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClassLibrary
{
    public class Department
    {
        public Department()
        {
            _employees = new Employee[0];
        }
        public string Name;
        public int EmployeeLimit;
        public double SalaryLimit;
        private Employee[] _employees;

        public Employee[] Employees
        {
            get => _employees;
        }

        public void AddEmployee(Employee emp)
        {
            if (_employees.Length < EmployeeLimit && (CalcAllSalary()+emp.Salary)<=SalaryLimit)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = emp;
            }
        }

        public double CalcAllSalary()
        {
            double total = 0;
            foreach (Employee emp in _employees)
            {
                total += emp.Salary;
            }
            return total;
        }
    }
}
