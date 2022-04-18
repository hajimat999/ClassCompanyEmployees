using System;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.FullName = "Hajimat Alisultanov";
            emp.Position = "Web Developer";
            emp.Salary = 9999999999;

            Employee emp1 = new Employee();
            emp1.FullName = "Nicat Muxtarov";
            emp1.Position = "Web Developer";
            emp1.Salary = 9997655;

            Employee emp2 = new Employee();
            emp2.FullName = "Nicat Muxtarov";
            emp2.Position = "Web Developer";
            emp2.Salary = 9997655;

            Employee emp3 = new Employee();
            emp3.FullName = "Nicat Muxtarov";
            emp3.Position = "Web Developer";
            emp3.Salary = 9997655;

            Console.WriteLine("Please enter company name");
            string companyname = Console.ReadLine();

            Company comp = new Company(companyname);
            comp.Limit = 4;

            comp.AddEmployee(emp);
            comp.AddEmployee(emp1);
            comp.AddEmployee(emp2);
            comp.AddEmployee(emp3);

            foreach (Employee item in comp.GetEmployees())
            {
                Console.WriteLine($"Tam Ad: {item.FullName} Vezife: {item.Position} Maash: {item.Salary} Nomre: {item.No}");

            }






        }
    }
}
