using AirlineTickets.ViewModels;
using System;
using System.Windows.Forms;

namespace AirlineTickets.Views
{
    public partial class EmployeeForm : Form
    {
        private readonly EmployeeViewModel _employeeViewModel;
        private int _currentlySelectedRowId = -1;
        public EmployeeForm(EmployeeViewModel employeeViewModel, string employeeUsername)
        {
            _employeeViewModel = employeeViewModel;
            _employeeViewModel.SetCurrentEmploye(employeeUsername);
            InitializeComponent();
            RefreshDataGridView();
        }

        private void dataGridView_Flights_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentlySelectedRowId = Int32.Parse(dataGridView_Flights.Rows[e.RowIndex].Cells[0].Value.ToString());

            (textBox_Source.Text,
             textBox_Destination.Text,
             textBox_Duration.Text) = _employeeViewModel.GetFlightInfo(_currentlySelectedRowId);
        }

        private void RefreshDataGridView()
        {
            dataGridView_Flights.DataSource = _employeeViewModel.GetFlights();
        }

        private void ClearTextboxes()
        {
            textBox_Source.Text = textBox_Duration.Text = textBox_Destination.Text = "";
            _currentlySelectedRowId = -1;
        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            if (_employeeViewModel.AddFlight(textBox_Source.Text, textBox_Destination.Text, textBox_Duration.Text) == true)
            {
                RefreshDataGridView();
                MessageBox.Show("Flight added");
                ClearTextboxes();
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (_employeeViewModel.DeleteFlight(_currentlySelectedRowId) == true)
            {
                RefreshDataGridView();
                MessageBox.Show("Flight deleted");
                ClearTextboxes();
            }
            else
            {
                MessageBox.Show("Error deleting flight");
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (_employeeViewModel.UpdateFlight(_currentlySelectedRowId, textBox_Source.Text, textBox_Destination.Text, textBox_Duration.Text) == true)
            {
                RefreshDataGridView();
                MessageBox.Show("Flight updated");
                ClearTextboxes();
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
