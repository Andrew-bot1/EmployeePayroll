using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class CommissionEmployee : Employee
    {
        public decimal SalesAmount { get; }
        public decimal CommissionRate { get; }

        public CommissionEmployee(string fName, string lName, string ssn, decimal salesAmount, decimal commissionRate) : base(fName, lName, ssn)
        {
            SalesAmount = salesAmount;
            CommissionRate = commissionRate;
        }

        public override decimal Earnings()
        {
            return SalesAmount * CommissionRate;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + "\n SSN: " + SSN + "\n Sales Amount: " + SalesAmount + "\n Commission Rate: " + CommissionRate + "\n Earnings: " + Earnings();
        }
    }
}
