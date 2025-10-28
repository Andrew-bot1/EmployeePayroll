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
            this.radSalEmp = new System.Windows.Forms.RadioButton();
            this.radHrEmp = new System.Windows.Forms.RadioButton();
            this.radComEmp = new System.Windows.Forms.RadioButton();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWklySal = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radSalEmp
            // 
            this.radSalEmp.AutoSize = true;
            this.radSalEmp.Location = new System.Drawing.Point(152, 106);
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
            this.radHrEmp.Location = new System.Drawing.Point(152, 129);
            this.radHrEmp.Name = "radHrEmp";
            this.radHrEmp.Size = new System.Drawing.Size(104, 17);
            this.radHrEmp.TabIndex = 1;
            this.radHrEmp.TabStop = true;
            this.radHrEmp.Text = "Hourly Employee";
            this.radHrEmp.UseVisualStyleBackColor = true;
            this.radHrEmp.UseWaitCursor = true;
            // 
            // radComEmp
            // 
            this.radComEmp.AutoSize = true;
            this.radComEmp.Location = new System.Drawing.Point(152, 152);
            this.radComEmp.Name = "radComEmp";
            this.radComEmp.Size = new System.Drawing.Size(124, 17);
            this.radComEmp.TabIndex = 2;
            this.radComEmp.TabStop = true;
            this.radComEmp.Text = "Commision Employee";
            this.radComEmp.UseVisualStyleBackColor = true;
            this.radComEmp.UseWaitCursor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(442, 103);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.UseWaitCursor = true;
            this.txtFirstName.Visible = false;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(442, 155);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 4;
            this.txtSSN.UseWaitCursor = true;
            this.txtSSN.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(442, 129);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.UseWaitCursor = true;
            this.txtLastName.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(548, 131);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Visible = false;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(548, 156);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 13);
            this.lblSSN.TabIndex = 8;
            this.lblSSN.Text = "SSN";
            this.lblSSN.UseWaitCursor = true;
            this.lblSSN.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Weekly Salary";
            this.label4.UseWaitCursor = true;
            this.label4.Visible = false;
            // 
            // txtWklySal
            // 
            this.txtWklySal.Location = new System.Drawing.Point(442, 181);
            this.txtWklySal.Name = "txtWklySal";
            this.txtWklySal.Size = new System.Drawing.Size(100, 20);
            this.txtWklySal.TabIndex = 9;
            this.txtWklySal.UseWaitCursor = true;
            this.txtWklySal.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(548, 106);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWklySal);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtFirstName);
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

        private System.Windows.Forms.RadioButton radSalEmp;
        private System.Windows.Forms.RadioButton radHrEmp;
        private System.Windows.Forms.RadioButton radComEmp;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWklySal;
        private System.Windows.Forms.Label lblFirstName;
    }
}

