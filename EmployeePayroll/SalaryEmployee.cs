using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class SalaryEmployee : Employee
    {
        public decimal WeeklySalary { get; }

        public SalaryEmployee(string fName, string lName, string ssn, decimal weeklySalary) : base(fName, lName, ssn)
        {
            WeeklySalary = weeklySalary;
        }

        public override decimal Earnings()
        {
            return WeeklySalary;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + "\n SSN: " + SSN + "\n Weekly Salary: " + WeeklySalary;
        }
    }
}
