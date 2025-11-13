using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class HourlyEmployee : Employee
    {
        public decimal Wage { get; }
        public decimal Hours { get; }

        public HourlyEmployee(string fName, string lName, string ssn, decimal wage, decimal hours) : base(fName, lName, ssn)
        {
            Wage = wage;
            Hours = hours;
        }

        public override decimal Earnings()
        {
            if (Hours <= 40)
            {
                return Wage * Hours;
            }
            else
            {
                return (Wage * Hours) + ((Wage/2) * Hours);
            }
        }

        public override string ToString()
        {
            return "Hourly Employee " + FirstName + " " + LastName + "\nSSN: " + SSN + "\nHours Worked: " + Hours + "\nEarnings: $" + Earnings() + ",";
        }
    }
}
