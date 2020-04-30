using AirlineTickets.ViewModels;
using System;
using System.Windows.Forms;

namespace AirlineTickets.Views
{
    public partial class AdminForm : Form
    {
        private readonly AdminViewModel _adminViewModel;
        private int _currentlySelectedRegularUserId = -1;
        private int _currentlySelectedCompanyId = -1;
        private FolderBrowserDialog _folderBrowserDialog;
        public AdminForm(AdminViewModel adminViewModel)
        {
            _adminViewModel = adminViewModel;
            InitializeComponent();
            RefreshRegularUsersDataGridView();
            RefreshCompaniesDataGridView();
            checkBox_TextReport.Checked = true;

            _folderBrowserDialog = new FolderBrowserDialog();
            _folderBrowserDialog.Description = "Select the directory where to store the report";
            _folderBrowserDialog.ShowNewFolderButton = false;
            _folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
        }

        private void RefreshRegularUsersDataGridView()
        {
            dataGridView_RegularUsers.DataSource = _adminViewModel.GetRegularUsers();
        }

        private void RefreshCompaniesDataGridView()
        {
            dataGridView_Companies.DataSource = _adminViewModel.GetCompanies();
        }

        private void dataGridView_RegularUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentlySelectedRegularUserId = Int32.Parse(
                    dataGridView_RegularUsers.Rows[e.RowIndex].Cells[0].Value.ToString()
                );

            (textBox_RegularUserUsername.Text,
                textBox_RegularUserPassword.Text) = _adminViewModel.GetRegularUserInfo(_currentlySelectedRegularUserId);
        }

        private void ClearRegularUserTextboxes()
        {
            textBox_RegularUserUsername.Text = textBox_RegularUserPassword.Text = "";
            _currentlySelectedRegularUserId = -1;
        }

        private void ClearCompanyTextbox()
        {
            textBox_CompanyName.Text = "";
            _currentlySelectedCompanyId = -1;
        }

        private void button_AddRegularUser_Click(object sender, EventArgs e)
        {
            if (_adminViewModel.AddRegularUser(textBox_RegularUserUsername.Text, textBox_RegularUserPassword.Text) == true)
            {
                RefreshRegularUsersDataGridView();
                MessageBox.Show("Regular user inserted");
                ClearRegularUserTextboxes();
            }
            else
            {
                MessageBox.Show("Username already taken or empty input");
            }
        }

        private void button_DeleteRegularUser_Click(object sender, EventArgs e)
        {
            if (_adminViewModel.DeleteRegularUser(_currentlySelectedRegularUserId) == true)
            {
                RefreshRegularUsersDataGridView();
                MessageBox.Show("Regular user deleted");
                ClearRegularUserTextboxes();
            }
            else
            {
                MessageBox.Show("No user selected");
            }
        }

        private void button_UpdateRegularUser_Click(object sender, EventArgs e)
        {
            if (_adminViewModel.UpdateRegularUser(_currentlySelectedRegularUserId, textBox_RegularUserUsername.Text, textBox_RegularUserPassword.Text) == true)
            {
                RefreshRegularUsersDataGridView();
                MessageBox.Show("Regular user updated");
                ClearRegularUserTextboxes();
            }
            else
            {
                MessageBox.Show("Username already taken or empty input");
            }
        }

        private void dataGridView_Companies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentlySelectedCompanyId = Int32.Parse(
                    dataGridView_Companies.Rows[e.RowIndex].Cells[0].Value.ToString()
                );

            textBox_CompanyName.Text = _adminViewModel.GetCompanyName(_currentlySelectedCompanyId);
        }

        private void button_AddCompany_Click(object sender, EventArgs e)
        {
            if (_adminViewModel.AddCompany(textBox_CompanyName.Text) == true)
            {
                RefreshCompaniesDataGridView();
                MessageBox.Show("Company added");
                ClearCompanyTextbox();
            }
            else
            {
                MessageBox.Show("Empty input");
            }
        }

        private void button_DeleteCompany_Click(object sender, EventArgs e)
        {
            if (_adminViewModel.DeleteCompany(_currentlySelectedCompanyId) == true)
            {
                RefreshCompaniesDataGridView();
                MessageBox.Show("Company deleted");
                ClearCompanyTextbox();
            }
            else
            {
                MessageBox.Show("No company selected");
            }

        }

        private void button_UpdateCompany_Click(object sender, EventArgs e)
        {
            if (_adminViewModel.UpdateCompany(_currentlySelectedCompanyId, textBox_CompanyName.Text) == true)
            {
                RefreshCompaniesDataGridView();
                MessageBox.Show("Company updated");
                ClearCompanyTextbox();
            }
            else
            {
                MessageBox.Show("Empty input");
            }
        }

        private void button_AddEmployee_Click(object sender, EventArgs e)
        {
            if (_adminViewModel.AddEmployee(_currentlySelectedCompanyId, textBox_EmployeeUsername.Text, textBox_EmployeePassword.Text) == true)
            {
                MessageBox.Show("Employee added");
            }
            else
            {
                MessageBox.Show("Username taken or no company selected");
                textBox_EmployeeUsername.Text = textBox_EmployeePassword.Text = "";
            }
        }

        private void checkBox_TextReport_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_TextReport.Checked == true)
            {
                checkBox_PDFReport.Checked = false;
            }
            else if (checkBox_PDFReport.Checked == false)
            {
                checkBox_TextReport.Checked = true;
            }
        }

        private void checkBox_PDFReport_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PDFReport.Checked == true)
            {
                checkBox_TextReport.Checked = false;
            }
            else if (checkBox_TextReport.Checked == false)
            {
                checkBox_PDFReport.Checked = true;
            }
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            if (_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                label_Path.Text = _folderBrowserDialog.SelectedPath;
            }
        }

        private void button_GenerateReport_Click(object sender, EventArgs e)
        {
            bool res = false;

            if (checkBox_PDFReport.Checked == true)
            {
                res =_adminViewModel.GenerateReport(label_Path.Text, textBox_ReportFileName.Text, "pdf");
            }
            else if (checkBox_TextReport.Checked == true)
            {
                res =_adminViewModel.GenerateReport(label_Path.Text, textBox_ReportFileName.Text, "txt");
            }

            if (res == true)
            {
                MessageBox.Show("Report file generated");
            }
            else
            {
                MessageBox.Show("You have to specify both the save path and the file name");
            }
        }
    }
}
