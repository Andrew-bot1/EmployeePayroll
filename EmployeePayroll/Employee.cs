using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SSN { get; }

        public Employee(string fName, string lName, string ssn)
        {
            FirstName = fName;
            LastName = lName;
            SSN = ssn;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + "\n SSN: " + SSN;
        }

        public abstract decimal Earnings();
    }
}
