using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Demo02.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public int EmpId { get; set; }
       // public Employee Manager { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
