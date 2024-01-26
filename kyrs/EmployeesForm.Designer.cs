namespace kyrs
{
    partial class EmployeesForm
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
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeePosition = new System.Windows.Forms.Label();
            this.txtNewEmployeeName = new System.Windows.Forms.TextBox();
            this.txtNewEmployeePosition = new System.Windows.Forms.TextBox();
            this.txtNewEmployeeSalary = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.lblEmployeeSalary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(12, 37);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(120, 95);
            this.listBoxEmployees.TabIndex = 0;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(12, 21);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(90, 13);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Имя сотрудника";
            // 
            // lblEmployeePosition
            // 
            this.lblEmployeePosition.AutoSize = true;
            this.lblEmployeePosition.Location = new System.Drawing.Point(138, 37);
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.Size = new System.Drawing.Size(126, 13);
            this.lblEmployeePosition.TabIndex = 2;
            this.lblEmployeePosition.Text = "Должность сотрудника";
            // 
            // txtNewEmployeeName
            // 
            this.txtNewEmployeeName.Location = new System.Drawing.Point(12, 141);
            this.txtNewEmployeeName.Name = "txtNewEmployeeName";
            this.txtNewEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txtNewEmployeeName.TabIndex = 3;
            // 
            // txtNewEmployeePosition
            // 
            this.txtNewEmployeePosition.Location = new System.Drawing.Point(12, 167);
            this.txtNewEmployeePosition.Name = "txtNewEmployeePosition";
            this.txtNewEmployeePosition.Size = new System.Drawing.Size(100, 20);
            this.txtNewEmployeePosition.TabIndex = 4;
            // 
            // txtNewEmployeeSalary
            // 
            this.txtNewEmployeeSalary.Location = new System.Drawing.Point(12, 193);
            this.txtNewEmployeeSalary.Name = "txtNewEmployeeSalary";
            this.txtNewEmployeeSalary.Size = new System.Drawing.Size(100, 20);
            this.txtNewEmployeeSalary.TabIndex = 5;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 219);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Добавить";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(12, 248);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateEmployee.TabIndex = 7;
            this.btnUpdateEmployee.Text = "Обновить";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(12, 277);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmployee.TabIndex = 8;
            this.btnDeleteEmployee.Text = "Удалить";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // lblEmployeeSalary
            // 
            this.lblEmployeeSalary.AutoSize = true;
            this.lblEmployeeSalary.Location = new System.Drawing.Point(138, 61);
            this.lblEmployeeSalary.Name = "lblEmployeeSalary";
            this.lblEmployeeSalary.Size = new System.Drawing.Size(55, 13);
            this.lblEmployeeSalary.TabIndex = 9;
            this.lblEmployeeSalary.Text = "Зарплата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Должность сотрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Зарплата сотрудника";
            // 
            // EmployeesForm
            // 
            this.BackgroundImage = global::kyrs.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmployeeSalary);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.txtNewEmployeeSalary);
            this.Controls.Add(this.txtNewEmployeePosition);
            this.Controls.Add(this.txtNewEmployeeName);
            this.Controls.Add(this.lblEmployeePosition);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.listBoxEmployees);
            this.Name = "EmployeesForm";
            this.ShowIcon = false;
            this.Text = "Сотрудники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeePosition;
        private System.Windows.Forms.TextBox txtNewEmployeeName;
        private System.Windows.Forms.TextBox txtNewEmployeePosition;
        private System.Windows.Forms.TextBox txtNewEmployeeSalary;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label lblEmployeeSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}