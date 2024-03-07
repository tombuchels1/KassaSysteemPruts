using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaSysteemPruts
{
    public class Employee : Person
    {
        public int EmployeeId {  get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, int phonenumber, int employeeid, decimal salary) : base(name, phonenumber)
        {
            EmployeeId = employeeid;
            Salary = salary;
        }
    }
}
