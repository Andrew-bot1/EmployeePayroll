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

        List<Employee> salEmps = new List<Employee>();
        List<Employee> hrsEmps = new List<Employee>();
        List<Employee> comEmps = new List<Employee>();
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
            if (radSalEmp.Checked)
            {
                SalaryEmployee salEmp = new SalaryEmployee(txtFirstName.Text, txtLastName.Text, txtSSN.Text, Convert.ToDecimal(txtWkSal.Text));
                salEmps.Add(salEmp);
            }
            if (radHrEmp.Checked)
            {
                HourlyEmployee hrEmp = new HourlyEmployee(txtFirstName.Text, txtLastName.Text, txtSSN.Text, Convert.ToDecimal(txtHrSal.Text), Convert.ToDecimal(txtHrs.Text));
                hrsEmps.Add(hrEmp);
            }
            if (radComEmp.Checked)
            {
                CommissionEmployee comEmp = new CommissionEmployee(txtFirstName.Text, txtLastName.Text, txtSSN.Text, Convert.ToDecimal(txtSlsAmt.Text), Convert.ToDecimal(txtComRat.Text));
                comEmps.Add(comEmp);
            }
        }
    }
}
