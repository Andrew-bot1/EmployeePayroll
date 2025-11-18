namespace EmployeePayroll
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblWkSal = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtHrSal = new System.Windows.Forms.TextBox();
            this.lblHrSal = new System.Windows.Forms.Label();
            this.lblComRat = new System.Windows.Forms.Label();
            this.txtComRat = new System.Windows.Forms.TextBox();
            this.lblHrs = new System.Windows.Forms.Label();
            this.txtHrs = new System.Windows.Forms.TextBox();
            this.txtSlsAmt = new System.Windows.Forms.TextBox();
            this.lblSlsAmt = new System.Windows.Forms.Label();
            this.txtWkSal = new System.Windows.Forms.TextBox();
            this.radSalEmp = new System.Windows.Forms.RadioButton();
            this.radHrEmp = new System.Windows.Forms.RadioButton();
            this.radComEmp = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(419, 60);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.UseWaitCursor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(419, 83);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.UseWaitCursor = true;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(419, 108);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 13);
            this.lblSSN.TabIndex = 13;
            this.lblSSN.Text = "SSN";
            this.lblSSN.UseWaitCursor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(313, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 14;
            this.txtFirstName.UseWaitCursor = true;
            // 
            // lblWkSal
            // 
            this.lblWkSal.AutoSize = true;
            this.lblWkSal.Location = new System.Drawing.Point(419, 131);
            this.lblWkSal.Name = "lblWkSal";
            this.lblWkSal.Size = new System.Drawing.Size(75, 13);
            this.lblWkSal.TabIndex = 15;
            this.lblWkSal.Text = "Weekly Salary";
            this.lblWkSal.UseWaitCursor = true;
            this.lblWkSal.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(313, 79);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 16;
            this.txtLastName.UseWaitCursor = true;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(313, 105);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 17;
            this.txtSSN.UseWaitCursor = true;
            // 
            // txtHrSal
            // 
            this.txtHrSal.Location = new System.Drawing.Point(313, 131);
            this.txtHrSal.Name = "txtHrSal";
            this.txtHrSal.Size = new System.Drawing.Size(100, 20);
            this.txtHrSal.TabIndex = 19;
            this.txtHrSal.UseWaitCursor = true;
            this.txtHrSal.Visible = false;
            // 
            // lblHrSal
            // 
            this.lblHrSal.AutoSize = true;
            this.lblHrSal.Location = new System.Drawing.Point(419, 134);
            this.lblHrSal.Name = "lblHrSal";
            this.lblHrSal.Size = new System.Drawing.Size(69, 13);
            this.lblHrSal.TabIndex = 20;
            this.lblHrSal.Text = "Hourly Salary";
            this.lblHrSal.UseWaitCursor = true;
            this.lblHrSal.Visible = false;
            // 
            // lblComRat
            // 
            this.lblComRat.AutoSize = true;
            this.lblComRat.Location = new System.Drawing.Point(419, 134);
            this.lblComRat.Name = "lblComRat";
            this.lblComRat.Size = new System.Drawing.Size(83, 13);
            this.lblComRat.TabIndex = 21;
            this.lblComRat.Text = "Commision Rate";
            this.lblComRat.UseWaitCursor = true;
            this.lblComRat.Visible = false;
            // 
            // txtComRat
            // 
            this.txtComRat.Location = new System.Drawing.Point(313, 131);
            this.txtComRat.Name = "txtComRat";
            this.txtComRat.Size = new System.Drawing.Size(100, 20);
            this.txtComRat.TabIndex = 22;
            this.txtComRat.UseWaitCursor = true;
            this.txtComRat.Visible = false;
            // 
            // lblHrs
            // 
            this.lblHrs.AutoSize = true;
            this.lblHrs.Location = new System.Drawing.Point(419, 160);
            this.lblHrs.Name = "lblHrs";
            this.lblHrs.Size = new System.Drawing.Size(35, 13);
            this.lblHrs.TabIndex = 23;
            this.lblHrs.Text = "Hours";
            this.lblHrs.UseWaitCursor = true;
            this.lblHrs.Visible = false;
            // 
            // txtHrs
            // 
            this.txtHrs.Location = new System.Drawing.Point(313, 160);
            this.txtHrs.Name = "txtHrs";
            this.txtHrs.Size = new System.Drawing.Size(100, 20);
            this.txtHrs.TabIndex = 24;
            this.txtHrs.UseWaitCursor = true;
            this.txtHrs.Visible = false;
            // 
            // txtSlsAmt
            // 
            this.txtSlsAmt.Location = new System.Drawing.Point(313, 160);
            this.txtSlsAmt.Name = "txtSlsAmt";
            this.txtSlsAmt.Size = new System.Drawing.Size(100, 20);
            this.txtSlsAmt.TabIndex = 25;
            this.txtSlsAmt.UseWaitCursor = true;
            this.txtSlsAmt.Visible = false;
            // 
            // lblSlsAmt
            // 
            this.lblSlsAmt.AutoSize = true;
            this.lblSlsAmt.Location = new System.Drawing.Point(419, 160);
            this.lblSlsAmt.Name = "lblSlsAmt";
            this.lblSlsAmt.Size = new System.Drawing.Size(72, 13);
            this.lblSlsAmt.TabIndex = 26;
            this.lblSlsAmt.Text = "Sales Amount";
            this.lblSlsAmt.UseWaitCursor = true;
            this.lblSlsAmt.Visible = false;
            // 
            // txtWkSal
            // 
            this.txtWkSal.Location = new System.Drawing.Point(313, 131);
            this.txtWkSal.Name = "txtWkSal";
            this.txtWkSal.Size = new System.Drawing.Size(100, 20);
            this.txtWkSal.TabIndex = 27;
            this.txtWkSal.UseWaitCursor = true;
            this.txtWkSal.Visible = false;
            // 
            // radSalEmp
            // 
            this.radSalEmp.AutoSize = true;
            this.radSalEmp.Location = new System.Drawing.Point(12, 84);
            this.radSalEmp.Name = "radSalEmp";
            this.radSalEmp.Size = new System.Drawing.Size(103, 17);
            this.radSalEmp.TabIndex = 0;
            this.radSalEmp.TabStop = true;
            this.radSalEmp.Text = "Salary Employee";
            this.radSalEmp.UseVisualStyleBackColor = true;
            this.radSalEmp.UseWaitCursor = true;
            this.radSalEmp.CheckedChanged += new System.EventHandler(this.radSalEmp_CheckedChanged_1);
            // 
            // radHrEmp
            // 
            this.radHrEmp.AutoSize = true;
            this.radHrEmp.Location = new System.Drawing.Point(12, 107);
            this.radHrEmp.Name = "radHrEmp";
            this.radHrEmp.Size = new System.Drawing.Size(104, 17);
            this.radHrEmp.TabIndex = 1;
            this.radHrEmp.TabStop = true;
            this.radHrEmp.Text = "Hourly Employee";
            this.radHrEmp.UseVisualStyleBackColor = true;
            this.radHrEmp.UseWaitCursor = true;
            this.radHrEmp.CheckedChanged += new System.EventHandler(this.radHrEmp_CheckedChanged);
            // 
            // radComEmp
            // 
            this.radComEmp.AutoSize = true;
            this.radComEmp.Location = new System.Drawing.Point(12, 130);
            this.radComEmp.Name = "radComEmp";
            this.radComEmp.Size = new System.Drawing.Size(124, 17);
            this.radComEmp.TabIndex = 2;
            this.radComEmp.TabStop = true;
            this.radComEmp.Text = "Commision Employee";
            this.radComEmp.UseVisualStyleBackColor = true;
            this.radComEmp.UseWaitCursor = true;
            this.radComEmp.CheckedChanged += new System.EventHandler(this.radComEmp_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(154, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.UseWaitCursor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(151, 281);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 29;
            this.lblOutput.UseWaitCursor = true;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(497, 276);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(0, 13);
            this.lblErrors.TabIndex = 30;
            this.lblErrors.UseWaitCursor = true;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 276);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(404, 342);
            this.lstOutput.TabIndex = 31;
            this.lstOutput.UseWaitCursor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(245, 209);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 32;
            this.btnSelect.Text = "Select File";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.UseWaitCursor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(432, 219);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(0, 13);
            this.lblSelect.TabIndex = 33;
            this.lblSelect.UseWaitCursor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(203, 247);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 34;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.UseWaitCursor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(122, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.UseWaitCursor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(203, 102);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(446, 342);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 626);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtWkSal);
            this.Controls.Add(this.lblSlsAmt);
            this.Controls.Add(this.txtSlsAmt);
            this.Controls.Add(this.txtHrs);
            this.Controls.Add(this.lblHrs);
            this.Controls.Add(this.txtComRat);
            this.Controls.Add(this.lblComRat);
            this.Controls.Add(this.lblHrSal);
            this.Controls.Add(this.txtHrSal);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblWkSal);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.radComEmp);
            this.Controls.Add(this.radHrEmp);
            this.Controls.Add(this.radSalEmp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblWkSal;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtHrSal;
        private System.Windows.Forms.Label lblHrSal;
        private System.Windows.Forms.Label lblComRat;
        private System.Windows.Forms.TextBox txtComRat;
        private System.Windows.Forms.Label lblHrs;
        private System.Windows.Forms.TextBox txtHrs;
        private System.Windows.Forms.TextBox txtSlsAmt;
        private System.Windows.Forms.Label lblSlsAmt;
        private System.Windows.Forms.TextBox txtWkSal;
        private System.Windows.Forms.RadioButton radSalEmp;
        private System.Windows.Forms.RadioButton radHrEmp;
        private System.Windows.Forms.RadioButton radComEmp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotal;
    }
}

