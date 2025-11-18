using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayroll
{
    public partial class Form1 : Form
    {
        StreamWriter fileWriter;
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

            try
            {
                //string fName = txtFirstName.Text;
                //string lName = txtLastName.Text;
                
                //txtFirstName.Text = "";
                //txtLastName.Text = "";
                //txtFirstName.Focus();


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
                            txtFirstName.Text = txtFirstName.Text.Replace(',', ' ');
                            txtLastName.Text = txtLastName.Text.Replace(',', ' ');


                            SalaryEmployee salEmp = new SalaryEmployee(txtFirstName.Text, txtLastName.Text, txtSSN.Text, Convert.ToDecimal(txtWkSal.Text));
                            allEmps.Add(salEmp);
                            fileWriter.WriteLine(salEmp);

                            if (errors.Count == 0)
                            {
                                lblErrors.Text = "Employee Added Successfully!";
                            }
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
                            txtFirstName.Text = txtFirstName.Text.Replace(',', ' ');
                            txtLastName.Text = txtLastName.Text.Replace(',', ' ');

                            HourlyEmployee hrEmp = new HourlyEmployee(txtFirstName.Text, txtLastName.Text, txtSSN.Text, Convert.ToDecimal(txtHrSal.Text), Convert.ToDecimal(txtHrs.Text));
                            allEmps.Add(hrEmp);
                            fileWriter.WriteLine(hrEmp);

                            if (errors.Count == 0)
                            {
                                lblErrors.Text = "Employee Added Successfully!";
                            }
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
                            txtFirstName.Text = txtFirstName.Text.Replace(',', ' ');
                            txtLastName.Text = txtLastName.Text.Replace(',', ' ');

                            CommissionEmployee comEmp = new CommissionEmployee(txtFirstName.Text, txtLastName.Text, txtSSN.Text, Convert.ToDecimal(txtSlsAmt.Text), Convert.ToDecimal(txtComRat.Text));
                            allEmps.Add(comEmp);
                            fileWriter.WriteLine(comEmp);

                            if (errors.Count == 0)
                            {
                                lblErrors.Text = "Employee Added Successfully!";
                            }
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error writing to specified file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            var filePicked = new SaveFileDialog();

            filePicked.CheckFileExists = false;
            result = filePicked.ShowDialog();
            fileName = filePicked.FileName;

            lblSelect.Text = fileName;

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name or Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        FileStream steam = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                        fileWriter = new StreamWriter(steam);

                        if (fileWriter == null)
                        {
                            MessageBox.Show("Error Grtting File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            btnAdd.Enabled = true;
                            btnSave.Enabled = true;
                            btnLoad.Enabled = true;
                            btnSelect.Enabled = false;
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening specified file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fileWriter.Close();

                    }
                }
            } }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            string filePath = lblSelect.Text;
            lstOutput.Items.Clear();
            fileWriter.Close();
            string output;

            if (filePath == "No File Selected")
            {
                MessageBox.Show("Please select a file first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            else
            {
                try
                {
                    StreamReader reader = new StreamReader(filePath);
                    string currentLine;

                    // System.IO.File.WriteAllLines(reader, allEmps.ToString());

                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        int indexOfComa = currentLine.IndexOf(',');
                        output = (currentLine.Substring(indexOfComa + 1)) ;
                        lstOutput.Items.Add(output);
                    }
                    reader.Close();

                    decimal total = 0;

                    foreach (Employee emp in allEmps)
                    {
                        total += emp.Earnings();
                    }

                    lblTotal.Text = "Total Payroll: $" + total;
                }
                catch (IOException)
                {
                    MessageBox.Show("Caanot Read File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                fileWriter.Close();
                btnAdd.Enabled = false;
                btnSelect.Enabled = true;
                btnSave.Enabled = false;
                btnLoad.Enabled = false;

                //btnAddPerson.Enabled = false;
                //btnSelectFile.Enabled = true;
                //btnSave.Enabled = false;
                //btnLoad.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot close file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
