using AirlineTickets.ViewModels;
using System;
using System.Windows.Forms;

namespace AirlineTickets.Views
{
    public partial class LoginForm : Form
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly AdminViewModel _adminViewModel;
        private readonly EmployeeViewModel _employeeViewModel;
        private readonly RegularUserViewModel _regularUserViewModel;
        public LoginForm(
            LoginViewModel loginViewModel,
            AdminViewModel adminViewModel,
            EmployeeViewModel employeeViewModel,
            RegularUserViewModel regularUserViewModel)
        {
            _loginViewModel = loginViewModel;
            _adminViewModel = adminViewModel;
            _employeeViewModel = employeeViewModel;
            _regularUserViewModel = regularUserViewModel;
            InitializeComponent();
        }

        private void button_Login_Click(object sender, System.EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;
            if (_loginViewModel.LoginAsAdministrator(username, password))
            {
                new AdminForm(_adminViewModel).Show();
            }
            else if (_loginViewModel.LoginAsEmployee(username, password))
            {
                new EmployeeForm(_employeeViewModel, username).Show();
            }
            else if (_loginViewModel.LoginAsRegularUser(username, password))
            {
                new RegularUserForm(_regularUserViewModel).Show();
            }
            else
            {
                MessageBox.Show("Login failed. Please retry");
            }

        }
    }
}
