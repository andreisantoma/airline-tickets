namespace AirlineTickets.Views
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_RegularUsers = new System.Windows.Forms.TabPage();
            this.button_UpdateRegularUser = new System.Windows.Forms.Button();
            this.button_DeleteRegularUser = new System.Windows.Forms.Button();
            this.button_AddRegularUser = new System.Windows.Forms.Button();
            this.label_RegularUserPassword = new System.Windows.Forms.Label();
            this.label_RegularUserUsername = new System.Windows.Forms.Label();
            this.textBox_RegularUserPassword = new System.Windows.Forms.TextBox();
            this.textBox_RegularUserUsername = new System.Windows.Forms.TextBox();
            this.dataGridView_RegularUsers = new System.Windows.Forms.DataGridView();
            this.tabPage_Companies = new System.Windows.Forms.TabPage();
            this.button_AddEmployee = new System.Windows.Forms.Button();
            this.label_EmployeePassword = new System.Windows.Forms.Label();
            this.textBox_EmployeePassword = new System.Windows.Forms.TextBox();
            this.label_EmployeeUsername = new System.Windows.Forms.Label();
            this.textBox_EmployeeUsername = new System.Windows.Forms.TextBox();
            this.button_UpdateCompany = new System.Windows.Forms.Button();
            this.button_DeleteCompany = new System.Windows.Forms.Button();
            this.button_AddCompany = new System.Windows.Forms.Button();
            this.label_CompanyName = new System.Windows.Forms.Label();
            this.textBox_CompanyName = new System.Windows.Forms.TextBox();
            this.dataGridView_Companies = new System.Windows.Forms.DataGridView();
            this.tabPage_Reports = new System.Windows.Forms.TabPage();
            this.label_ReportsInfo = new System.Windows.Forms.Label();
            this.checkBox_TextReport = new System.Windows.Forms.CheckBox();
            this.checkBox_PDFReport = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Browse = new System.Windows.Forms.Button();
            this.label_Path = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ReportFileName = new System.Windows.Forms.TextBox();
            this.button_GenerateReport = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage_RegularUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RegularUsers)).BeginInit();
            this.tabPage_Companies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Companies)).BeginInit();
            this.tabPage_Reports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_RegularUsers);
            this.tabControl.Controls.Add(this.tabPage_Companies);
            this.tabControl.Controls.Add(this.tabPage_Reports);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(504, 381);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_RegularUsers
            // 
            this.tabPage_RegularUsers.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_RegularUsers.Controls.Add(this.button_UpdateRegularUser);
            this.tabPage_RegularUsers.Controls.Add(this.button_DeleteRegularUser);
            this.tabPage_RegularUsers.Controls.Add(this.button_AddRegularUser);
            this.tabPage_RegularUsers.Controls.Add(this.label_RegularUserPassword);
            this.tabPage_RegularUsers.Controls.Add(this.label_RegularUserUsername);
            this.tabPage_RegularUsers.Controls.Add(this.textBox_RegularUserPassword);
            this.tabPage_RegularUsers.Controls.Add(this.textBox_RegularUserUsername);
            this.tabPage_RegularUsers.Controls.Add(this.dataGridView_RegularUsers);
            this.tabPage_RegularUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RegularUsers.Name = "tabPage_RegularUsers";
            this.tabPage_RegularUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RegularUsers.Size = new System.Drawing.Size(496, 355);
            this.tabPage_RegularUsers.TabIndex = 0;
            this.tabPage_RegularUsers.Text = "Regular users";
            // 
            // button_UpdateRegularUser
            // 
            this.button_UpdateRegularUser.Location = new System.Drawing.Point(354, 252);
            this.button_UpdateRegularUser.Name = "button_UpdateRegularUser";
            this.button_UpdateRegularUser.Size = new System.Drawing.Size(75, 23);
            this.button_UpdateRegularUser.TabIndex = 6;
            this.button_UpdateRegularUser.Text = "Update";
            this.button_UpdateRegularUser.UseVisualStyleBackColor = true;
            this.button_UpdateRegularUser.Click += new System.EventHandler(this.button_UpdateRegularUser_Click);
            // 
            // button_DeleteRegularUser
            // 
            this.button_DeleteRegularUser.Location = new System.Drawing.Point(354, 216);
            this.button_DeleteRegularUser.Name = "button_DeleteRegularUser";
            this.button_DeleteRegularUser.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteRegularUser.TabIndex = 5;
            this.button_DeleteRegularUser.Text = "Delete";
            this.button_DeleteRegularUser.UseVisualStyleBackColor = true;
            this.button_DeleteRegularUser.Click += new System.EventHandler(this.button_DeleteRegularUser_Click);
            // 
            // button_AddRegularUser
            // 
            this.button_AddRegularUser.Location = new System.Drawing.Point(354, 180);
            this.button_AddRegularUser.Name = "button_AddRegularUser";
            this.button_AddRegularUser.Size = new System.Drawing.Size(75, 23);
            this.button_AddRegularUser.TabIndex = 1;
            this.button_AddRegularUser.Text = "Add";
            this.button_AddRegularUser.UseVisualStyleBackColor = true;
            this.button_AddRegularUser.Click += new System.EventHandler(this.button_AddRegularUser_Click);
            // 
            // label_RegularUserPassword
            // 
            this.label_RegularUserPassword.AutoSize = true;
            this.label_RegularUserPassword.Location = new System.Drawing.Point(309, 115);
            this.label_RegularUserPassword.Name = "label_RegularUserPassword";
            this.label_RegularUserPassword.Size = new System.Drawing.Size(53, 13);
            this.label_RegularUserPassword.TabIndex = 4;
            this.label_RegularUserPassword.Text = "Password";
            // 
            // label_RegularUserUsername
            // 
            this.label_RegularUserUsername.AutoSize = true;
            this.label_RegularUserUsername.Location = new System.Drawing.Point(307, 80);
            this.label_RegularUserUsername.Name = "label_RegularUserUsername";
            this.label_RegularUserUsername.Size = new System.Drawing.Size(55, 13);
            this.label_RegularUserUsername.TabIndex = 3;
            this.label_RegularUserUsername.Text = "Username";
            // 
            // textBox_RegularUserPassword
            // 
            this.textBox_RegularUserPassword.Location = new System.Drawing.Point(368, 112);
            this.textBox_RegularUserPassword.Name = "textBox_RegularUserPassword";
            this.textBox_RegularUserPassword.Size = new System.Drawing.Size(100, 20);
            this.textBox_RegularUserPassword.TabIndex = 2;
            // 
            // textBox_RegularUserUsername
            // 
            this.textBox_RegularUserUsername.Location = new System.Drawing.Point(368, 77);
            this.textBox_RegularUserUsername.Name = "textBox_RegularUserUsername";
            this.textBox_RegularUserUsername.Size = new System.Drawing.Size(100, 20);
            this.textBox_RegularUserUsername.TabIndex = 1;
            // 
            // dataGridView_RegularUsers
            // 
            this.dataGridView_RegularUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_RegularUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RegularUsers.Location = new System.Drawing.Point(8, 6);
            this.dataGridView_RegularUsers.Name = "dataGridView_RegularUsers";
            this.dataGridView_RegularUsers.ReadOnly = true;
            this.dataGridView_RegularUsers.Size = new System.Drawing.Size(271, 341);
            this.dataGridView_RegularUsers.TabIndex = 1;
            this.dataGridView_RegularUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RegularUsers_CellClick);
            // 
            // tabPage_Companies
            // 
            this.tabPage_Companies.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_Companies.Controls.Add(this.button_AddEmployee);
            this.tabPage_Companies.Controls.Add(this.label_EmployeePassword);
            this.tabPage_Companies.Controls.Add(this.textBox_EmployeePassword);
            this.tabPage_Companies.Controls.Add(this.label_EmployeeUsername);
            this.tabPage_Companies.Controls.Add(this.textBox_EmployeeUsername);
            this.tabPage_Companies.Controls.Add(this.button_UpdateCompany);
            this.tabPage_Companies.Controls.Add(this.button_DeleteCompany);
            this.tabPage_Companies.Controls.Add(this.button_AddCompany);
            this.tabPage_Companies.Controls.Add(this.label_CompanyName);
            this.tabPage_Companies.Controls.Add(this.textBox_CompanyName);
            this.tabPage_Companies.Controls.Add(this.dataGridView_Companies);
            this.tabPage_Companies.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Companies.Name = "tabPage_Companies";
            this.tabPage_Companies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Companies.Size = new System.Drawing.Size(496, 355);
            this.tabPage_Companies.TabIndex = 1;
            this.tabPage_Companies.Text = "Companies";
            // 
            // button_AddEmployee
            // 
            this.button_AddEmployee.Location = new System.Drawing.Point(335, 305);
            this.button_AddEmployee.Name = "button_AddEmployee";
            this.button_AddEmployee.Size = new System.Drawing.Size(105, 23);
            this.button_AddEmployee.TabIndex = 14;
            this.button_AddEmployee.Text = "Add employee";
            this.button_AddEmployee.UseVisualStyleBackColor = true;
            this.button_AddEmployee.Click += new System.EventHandler(this.button_AddEmployee_Click);
            // 
            // label_EmployeePassword
            // 
            this.label_EmployeePassword.AutoSize = true;
            this.label_EmployeePassword.Location = new System.Drawing.Point(297, 268);
            this.label_EmployeePassword.Name = "label_EmployeePassword";
            this.label_EmployeePassword.Size = new System.Drawing.Size(53, 13);
            this.label_EmployeePassword.TabIndex = 13;
            this.label_EmployeePassword.Text = "Password";
            // 
            // textBox_EmployeePassword
            // 
            this.textBox_EmployeePassword.Location = new System.Drawing.Point(365, 265);
            this.textBox_EmployeePassword.Name = "textBox_EmployeePassword";
            this.textBox_EmployeePassword.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeePassword.TabIndex = 12;
            // 
            // label_EmployeeUsername
            // 
            this.label_EmployeeUsername.AutoSize = true;
            this.label_EmployeeUsername.Location = new System.Drawing.Point(295, 232);
            this.label_EmployeeUsername.Name = "label_EmployeeUsername";
            this.label_EmployeeUsername.Size = new System.Drawing.Size(55, 13);
            this.label_EmployeeUsername.TabIndex = 11;
            this.label_EmployeeUsername.Text = "Username";
            // 
            // textBox_EmployeeUsername
            // 
            this.textBox_EmployeeUsername.Location = new System.Drawing.Point(365, 229);
            this.textBox_EmployeeUsername.Name = "textBox_EmployeeUsername";
            this.textBox_EmployeeUsername.Size = new System.Drawing.Size(100, 20);
            this.textBox_EmployeeUsername.TabIndex = 10;
            // 
            // button_UpdateCompany
            // 
            this.button_UpdateCompany.Location = new System.Drawing.Point(352, 154);
            this.button_UpdateCompany.Name = "button_UpdateCompany";
            this.button_UpdateCompany.Size = new System.Drawing.Size(75, 23);
            this.button_UpdateCompany.TabIndex = 9;
            this.button_UpdateCompany.Text = "Update";
            this.button_UpdateCompany.UseVisualStyleBackColor = true;
            this.button_UpdateCompany.Click += new System.EventHandler(this.button_UpdateCompany_Click);
            // 
            // button_DeleteCompany
            // 
            this.button_DeleteCompany.Location = new System.Drawing.Point(352, 118);
            this.button_DeleteCompany.Name = "button_DeleteCompany";
            this.button_DeleteCompany.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteCompany.TabIndex = 8;
            this.button_DeleteCompany.Text = "Delete";
            this.button_DeleteCompany.UseVisualStyleBackColor = true;
            this.button_DeleteCompany.Click += new System.EventHandler(this.button_DeleteCompany_Click);
            // 
            // button_AddCompany
            // 
            this.button_AddCompany.Location = new System.Drawing.Point(352, 82);
            this.button_AddCompany.Name = "button_AddCompany";
            this.button_AddCompany.Size = new System.Drawing.Size(75, 23);
            this.button_AddCompany.TabIndex = 7;
            this.button_AddCompany.Text = "Add";
            this.button_AddCompany.UseVisualStyleBackColor = true;
            this.button_AddCompany.Click += new System.EventHandler(this.button_AddCompany_Click);
            // 
            // label_CompanyName
            // 
            this.label_CompanyName.AutoSize = true;
            this.label_CompanyName.Location = new System.Drawing.Point(315, 41);
            this.label_CompanyName.Name = "label_CompanyName";
            this.label_CompanyName.Size = new System.Drawing.Size(35, 13);
            this.label_CompanyName.TabIndex = 5;
            this.label_CompanyName.Text = "Name";
            // 
            // textBox_CompanyName
            // 
            this.textBox_CompanyName.Location = new System.Drawing.Point(365, 38);
            this.textBox_CompanyName.Name = "textBox_CompanyName";
            this.textBox_CompanyName.Size = new System.Drawing.Size(100, 20);
            this.textBox_CompanyName.TabIndex = 4;
            // 
            // dataGridView_Companies
            // 
            this.dataGridView_Companies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Companies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Companies.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Companies.Name = "dataGridView_Companies";
            this.dataGridView_Companies.ReadOnly = true;
            this.dataGridView_Companies.Size = new System.Drawing.Size(271, 341);
            this.dataGridView_Companies.TabIndex = 2;
            this.dataGridView_Companies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Companies_CellClick);
            // 
            // tabPage_Reports
            // 
            this.tabPage_Reports.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_Reports.Controls.Add(this.button_GenerateReport);
            this.tabPage_Reports.Controls.Add(this.textBox_ReportFileName);
            this.tabPage_Reports.Controls.Add(this.label2);
            this.tabPage_Reports.Controls.Add(this.label_Path);
            this.tabPage_Reports.Controls.Add(this.button_Browse);
            this.tabPage_Reports.Controls.Add(this.label1);
            this.tabPage_Reports.Controls.Add(this.checkBox_PDFReport);
            this.tabPage_Reports.Controls.Add(this.checkBox_TextReport);
            this.tabPage_Reports.Controls.Add(this.label_ReportsInfo);
            this.tabPage_Reports.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Reports.Name = "tabPage_Reports";
            this.tabPage_Reports.Size = new System.Drawing.Size(496, 355);
            this.tabPage_Reports.TabIndex = 2;
            this.tabPage_Reports.Text = "Reports";
            // 
            // label_ReportsInfo
            // 
            this.label_ReportsInfo.AutoSize = true;
            this.label_ReportsInfo.Location = new System.Drawing.Point(29, 51);
            this.label_ReportsInfo.Name = "label_ReportsInfo";
            this.label_ReportsInfo.Size = new System.Drawing.Size(159, 13);
            this.label_ReportsInfo.TabIndex = 0;
            this.label_ReportsInfo.Text = "Select type of report to generate";
            // 
            // checkBox_TextReport
            // 
            this.checkBox_TextReport.AutoSize = true;
            this.checkBox_TextReport.Location = new System.Drawing.Point(29, 82);
            this.checkBox_TextReport.Name = "checkBox_TextReport";
            this.checkBox_TextReport.Size = new System.Drawing.Size(70, 17);
            this.checkBox_TextReport.TabIndex = 1;
            this.checkBox_TextReport.Text = ".txt report";
            this.checkBox_TextReport.UseVisualStyleBackColor = true;
            this.checkBox_TextReport.CheckedChanged += new System.EventHandler(this.checkBox_TextReport_CheckedChanged);
            // 
            // checkBox_PDFReport
            // 
            this.checkBox_PDFReport.AutoSize = true;
            this.checkBox_PDFReport.Location = new System.Drawing.Point(29, 105);
            this.checkBox_PDFReport.Name = "checkBox_PDFReport";
            this.checkBox_PDFReport.Size = new System.Drawing.Size(74, 17);
            this.checkBox_PDFReport.TabIndex = 2;
            this.checkBox_PDFReport.Text = ".pdf report";
            this.checkBox_PDFReport.UseVisualStyleBackColor = true;
            this.checkBox_PDFReport.CheckedChanged += new System.EventHandler(this.checkBox_PDFReport_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected path:";
            // 
            // button_Browse
            // 
            this.button_Browse.Location = new System.Drawing.Point(32, 193);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(75, 23);
            this.button_Browse.TabIndex = 4;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.Location = new System.Drawing.Point(111, 167);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(0, 13);
            this.label_Path.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File name (without extension)";
            // 
            // textBox_ReportFileName
            // 
            this.textBox_ReportFileName.Location = new System.Drawing.Point(191, 241);
            this.textBox_ReportFileName.Name = "textBox_ReportFileName";
            this.textBox_ReportFileName.Size = new System.Drawing.Size(100, 20);
            this.textBox_ReportFileName.TabIndex = 7;
            // 
            // button_GenerateReport
            // 
            this.button_GenerateReport.Location = new System.Drawing.Point(318, 239);
            this.button_GenerateReport.Name = "button_GenerateReport";
            this.button_GenerateReport.Size = new System.Drawing.Size(75, 23);
            this.button_GenerateReport.TabIndex = 8;
            this.button_GenerateReport.Text = "Generate";
            this.button_GenerateReport.UseVisualStyleBackColor = true;
            this.button_GenerateReport.Click += new System.EventHandler(this.button_GenerateReport_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Administrator panel";
            this.tabControl.ResumeLayout(false);
            this.tabPage_RegularUsers.ResumeLayout(false);
            this.tabPage_RegularUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RegularUsers)).EndInit();
            this.tabPage_Companies.ResumeLayout(false);
            this.tabPage_Companies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Companies)).EndInit();
            this.tabPage_Reports.ResumeLayout(false);
            this.tabPage_Reports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_RegularUsers;
        private System.Windows.Forms.TabPage tabPage_Companies;
        private System.Windows.Forms.Button button_UpdateRegularUser;
        private System.Windows.Forms.Button button_DeleteRegularUser;
        private System.Windows.Forms.Button button_AddRegularUser;
        private System.Windows.Forms.Label label_RegularUserPassword;
        private System.Windows.Forms.Label label_RegularUserUsername;
        private System.Windows.Forms.TextBox textBox_RegularUserPassword;
        private System.Windows.Forms.TextBox textBox_RegularUserUsername;
        private System.Windows.Forms.DataGridView dataGridView_RegularUsers;
        private System.Windows.Forms.DataGridView dataGridView_Companies;
        private System.Windows.Forms.Label label_CompanyName;
        private System.Windows.Forms.TextBox textBox_CompanyName;
        private System.Windows.Forms.Button button_UpdateCompany;
        private System.Windows.Forms.Button button_DeleteCompany;
        private System.Windows.Forms.Button button_AddCompany;
        private System.Windows.Forms.Button button_AddEmployee;
        private System.Windows.Forms.Label label_EmployeePassword;
        private System.Windows.Forms.TextBox textBox_EmployeePassword;
        private System.Windows.Forms.Label label_EmployeeUsername;
        private System.Windows.Forms.TextBox textBox_EmployeeUsername;
        private System.Windows.Forms.TabPage tabPage_Reports;
        private System.Windows.Forms.CheckBox checkBox_PDFReport;
        private System.Windows.Forms.CheckBox checkBox_TextReport;
        private System.Windows.Forms.Label label_ReportsInfo;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.Button button_GenerateReport;
        private System.Windows.Forms.TextBox textBox_ReportFileName;
        private System.Windows.Forms.Label label2;
    }
}