using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LinQ
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
        public int Salary { get; set; }
    }

    class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }

}
