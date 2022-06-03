using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClassLibrary
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;

        public string Name
        {
            get => _name;
            set
            {
                if (CheckName(value))
                    _name = value;
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                if (CheckName(value))
                    _surname = value;
            }
        }

        public double Salary
        {
            get => _salary;
            set
            {
                if (value >= 250)
                    _salary = value;
            }
        }

        public bool CheckName(string name)
        {
            if (!String.IsNullOrWhiteSpace(name) && Char.IsUpper(name[0]) && IsContainsOnlyLetter(name))
                return true;
            else
                return false;
        }

        public bool IsContainsOnlyLetter(string str)
        {
            if (str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!Char.IsLetter(str[i]))
                        return false;
                }
                return true;
            }
            return false;
        }
    }
}
