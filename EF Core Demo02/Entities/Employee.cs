using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Demo02.Entities
{
    internal class Employee
    {
        public int EmpId { get; set; }

        public string Name { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }

        public double TotalSalary { get; set; }
        public int? WorkForId { get; set; }
        public Department? WorkFor { get; set; }
    }
}
