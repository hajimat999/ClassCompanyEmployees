using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Employee
    {
        private static int ID = 1;
        public int No { get; set; }
        public string  FullName { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }

        public Employee()
        {
            No = ID;
            ID++;
        }

    }
}
