namespace Eclerx.Question1.RiteshKumar
{
    partial class GridEmployeeDetails
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
            this.LblEmployeeNo = new System.Windows.Forms.Label();
            this.LblEmployeeName = new System.Windows.Forms.Label();
            this.LblSalary = new System.Windows.Forms.Label();
            this.TxtEmployeeNo = new System.Windows.Forms.TextBox();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.RbPayroll = new System.Windows.Forms.RadioButton();
            this.RbConsultant = new System.Windows.Forms.RadioButton();
            this.GroupEmployeeType = new System.Windows.Forms.GroupBox();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.GroupEmployeeType.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblEmployeeNo
            // 
            this.LblEmployeeNo.AutoSize = true;
            this.LblEmployeeNo.Location = new System.Drawing.Point(97, 42);
            this.LblEmployeeNo.Name = "LblEmployeeNo";
            this.LblEmployeeNo.Size = new System.Drawing.Size(90, 16);
            this.LblEmployeeNo.TabIndex = 0;
            this.LblEmployeeNo.Text = "Employee No";
            // 
            // LblEmployeeName
            // 
            this.LblEmployeeName.AutoSize = true;
            this.LblEmployeeName.Location = new System.Drawing.Point(97, 88);
            this.LblEmployeeName.Name = "LblEmployeeName";
            this.LblEmployeeName.Size = new System.Drawing.Size(109, 16);
            this.LblEmployeeName.TabIndex = 1;
            this.LblEmployeeName.Text = "Emoloyee Name";
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.Location = new System.Drawing.Point(97, 133);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(46, 16);
            this.LblSalary.TabIndex = 2;
            this.LblSalary.Text = "Salary";
            // 
            // TxtEmployeeNo
            // 
            this.TxtEmployeeNo.Location = new System.Drawing.Point(252, 42);
            this.TxtEmployeeNo.Name = "TxtEmployeeNo";
            this.TxtEmployeeNo.Size = new System.Drawing.Size(100, 22);
            this.TxtEmployeeNo.TabIndex = 3;
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.Location = new System.Drawing.Point(252, 88);
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(100, 22);
            this.TxtEmployeeName.TabIndex = 4;
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(252, 127);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(100, 22);
            this.TxtSalary.TabIndex = 5;
            // 
            // RbPayroll
            // 
            this.RbPayroll.AutoSize = true;
            this.RbPayroll.Location = new System.Drawing.Point(28, 35);
            this.RbPayroll.Name = "RbPayroll";
            this.RbPayroll.Size = new System.Drawing.Size(70, 20);
            this.RbPayroll.TabIndex = 6;
            this.RbPayroll.TabStop = true;
            this.RbPayroll.Text = "Payroll";
            this.RbPayroll.UseVisualStyleBackColor = true;
            // 
            // RbConsultant
            // 
            this.RbConsultant.AutoSize = true;
            this.RbConsultant.Location = new System.Drawing.Point(28, 74);
            this.RbConsultant.Name = "RbConsultant";
            this.RbConsultant.Size = new System.Drawing.Size(90, 20);
            this.RbConsultant.TabIndex = 7;
            this.RbConsultant.TabStop = true;
            this.RbConsultant.Text = "Consultant";
            this.RbConsultant.UseVisualStyleBackColor = true;
            // 
            // GroupEmployeeType
            // 
            this.GroupEmployeeType.Controls.Add(this.RbPayroll);
            this.GroupEmployeeType.Controls.Add(this.RbConsultant);
            this.GroupEmployeeType.Location = new System.Drawing.Point(455, 42);
            this.GroupEmployeeType.Name = "GroupEmployeeType";
            this.GroupEmployeeType.Size = new System.Drawing.Size(200, 120);
            this.GroupEmployeeType.TabIndex = 9;
            this.GroupEmployeeType.TabStop = false;
            this.GroupEmployeeType.Text = "Employee Type";
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Location = new System.Drawing.Point(212, 224);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNew.TabIndex = 10;
            this.BtnAddNew.Text = "Add New";
            this.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(364, 224);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 11;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // GridEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 282);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.GroupEmployeeType);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.TxtEmployeeName);
            this.Controls.Add(this.TxtEmployeeNo);
            this.Controls.Add(this.LblSalary);
            this.Controls.Add(this.LblEmployeeName);
            this.Controls.Add(this.LblEmployeeNo);
            this.Name = "GridEmployeeDetails";
            this.Text = "Employee Details";
            this.GroupEmployeeType.ResumeLayout(false);
            this.GroupEmployeeType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmployeeNo;
        private System.Windows.Forms.Label LblEmployeeName;
        private System.Windows.Forms.Label LblSalary;
        private System.Windows.Forms.TextBox TxtEmployeeNo;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.RadioButton RbPayroll;
        private System.Windows.Forms.RadioButton RbConsultant;
        private System.Windows.Forms.GroupBox GroupEmployeeType;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button BtnReset;
    }
}

