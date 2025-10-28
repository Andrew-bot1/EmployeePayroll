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
        public Form1()
        {
            InitializeComponent();
        }

        private void radSalEmp_CheckedChanged(object sender, EventArgs e)
        {
            Unhide();
        }

        private void radSalEmp_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Unhide()
        {
            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblSSN.Visible = true;
            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtSSN.Visible = true;
        }
    }
}
