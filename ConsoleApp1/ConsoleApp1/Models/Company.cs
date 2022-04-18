using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Company
    {
        private string _companyname;
        public string CompanyName
        {
            get => _companyname;


            set
            {
                if(char.IsUpper(value[0]))
                {
                    
                    foreach (char item in value)
                    {
                        if(!char.IsDigit(item) && !char.IsLetter(item) && !char.IsWhiteSpace(item))
                        {
                            Console.WriteLine("Try to add company name again");
                            value = Console.ReadLine();


                        }

                    }
                    _companyname = value;


                }
                else
                {
                    Console.WriteLine("Company adi sehvidir");
                    return;
                }
            }
            

        }
        public int Limit { get; set; }
        public Employee[] employees;

        public Company()
        {
            employees = new Employee[0];
        }

        public Company(string companyname) : this()
        {
            CompanyName = companyname;

        }
        public void AddEmployee(Employee employees1)
        {
            if(employees.Length < Limit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employees1;
            }
        }
        public Employee[] GetEmployees()
        {
            return employees;

        }
    }
}
