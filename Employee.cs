using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DotnetTraining
{
    public class Employee
    {
        public Employee()
        {
            this.EmployeeId = 1;
            this.EmployeeName = "AS";
        }
        public Employee(int employeeId,string employeeName)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
        }
        public Employee(int employeeId, string employeeName, string fullName)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            fullName = "Mr" + employeeName;
        }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }
}
