using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayroll
{
    public partial class Form1 : Form
    {
        List<Employee> allEmps = new List<Employee>();
        List<String> errors = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }


        private void radSalEmp_CheckedChanged_1(object sender, EventArgs e)
        {
            // Unhide();
            Hide();
            txtWkSal.Visible = true;
            lblWkSal.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Hide()
        {
            txtWkSal.Visible = false;
            lblWkSal.Visible = false;
            txtHrs.Visible = false;
            lblHrs.Visible = false;
            txtHrSal.Visible = false;
            lblHrSal.Visible = false;
            txtComRat.Visible = false;
            lblComRat.Visible = false;
            txtSlsAmt.Visible = false;
            lblSlsAmt.Visible = false;
        }

        private void radHrEmp_CheckedChanged(object sender, EventArgs e)
        {
            Hide();
            txtHrs.Visible = true;
            lblHrs.Visible = true;
            txtHrSal.Visible = true;
            lblHrSal.Visible = true;
        }

        private void radComEmp_CheckedChanged(object sender, EventArgs e)
        {
            Hide();
            txtComRat.Visible = true;
            lblComRat.Visible = true;
            txtSlsAmt.Visible = true;
            lblSlsAmt.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errors.Clear();
            lblErrors.Text = "";
            if (radSalEmp.Checked)
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtSSN.Text == "" || txtWkSal.Text == "")
                {
                    errors.Add("Please fill in all fields.");
                }
                else
                {
                    if (txtSSN.Text.Length != 9)
                    {
                        errors.Add("SSN must be 9 digits.");
                    }
                    if (decimal.TryParse(txtWkSal.Text, out _) == false)
                    {
                        errors.Add("Weekly Salary must be a valid decimal number.");
                    }
                    else if (Convert.ToDecimal(txtWkSal.Text) < 0)
                    {
                        errors.Add("Weekly Salary must be a positive number.");
                    }
                    if (errors.Count == 0)
                    {
                        SalaryEmployee salEmp = new SalaryEmployee(txtFirstName.Text, txtLastName.Text, txtSSN.Text, Convert.ToDecimal(txtWkSal.Text));
                        allEmps.Add(salEmp);
                    }
                }
                
            }
            if (radHrEmp.Checked)
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtSSN.Text == "" || txtHrSal.Text == "" || txtHrs.Text == "")
                {
                    errors.Add("Please fill in all fields.");
                }
                else
                {
                    if (txtSSN.Text.Length != 9)
                    {
                        errors.Add("SSN must be 9 digits.");
                    }
                    if (decimal.TryParse(txtHrs.Text, out _) == false)
                    {
                        errors.Add("Hours Worked must be a valid decimal number.");
                    }
                    else if (Convert.ToDecimal(txtHrs.Text) < 0)
                    {
                        errors.Add("Hours Worked must be a positive number.");
                    }
                    if (errors.Count == 0)
                    {
                        HourlyEmployee hrEmp = new HourlyEmployee(txtFirstName.Text, txtLastName.Text, txtSSN.Text, Convert.ToDecimal(txtHrSal.Text), Convert.ToDecimal(txtHrs.Text));
                        allEmps.Add(hrEmp);
                    }
                }
                
            }
            if (radComEmp.Checked)
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtSSN.Text == "" || txtComRat.Text == "" || txtSlsAmt.Text == "")
                {
                    errors.Add("Please fill in all fields.");
                }
                else
                {
                    if (txtSSN.Text.Length != 9)
                    {
                        errors.Add("SSN must be 9 digits.");
                    }
                    if (decimal.TryParse(txtSlsAmt.Text, out _) == false)
                    {
                        errors.Add("Sales Amount must be a valid decimal number.");
                    }
                    else if (Convert.ToDecimal(txtSlsAmt.Text) < 0)
                    {
                        errors.Add("Sales Amount must be a positive number.");
                    }
                    if (decimal.TryParse(txtComRat.Text, out _) == false)
                    {
                        errors.Add("Commission Rate must be a valid decimal number.");
                    }
                    else if (Convert.ToDecimal(txtComRat.Text) < 0 || Convert.ToDecimal(txtComRat.Text) > 1)
                    {
                        errors.Add("Commission Rate must be a decimal between 0 and 1.");
                    }
                    if (errors.Count == 0)
                    {
                        CommissionEmployee comEmp = new CommissionEmployee(txtFirstName.Text, txtLastName.Text, txtSSN.Text, Convert.ToDecimal(txtSlsAmt.Text), Convert.ToDecimal(txtComRat.Text));
                        allEmps.Add(comEmp);
                    }
                }
                
            }

            lstOutput.Items.Clear();

            if (errors.Count > 0)
            {
                foreach (String err in errors)
                {
                    lblErrors.Text += err + "\n";
                }
                return;
            }

            foreach (Employee emp in allEmps)
            {
                lstOutput.Items.Add(emp.ToString());
            }
        }
    }
}
