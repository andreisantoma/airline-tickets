using AirlineTickets.ViewModels;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AirlineTickets.Views
{
    public partial class RegularUserForm : Form
    {
        private readonly RegularUserViewModel _regularUserViewModel;
        public RegularUserForm(RegularUserViewModel regularUserViewModel)
        {
            _regularUserViewModel = regularUserViewModel;
            InitializeComponent();
        }

        private void textBox_Search_Enter(object sender, System.EventArgs e)
        {
            if (textBox_Search.Font.Italic == true)
            {
                textBox_Search.Text = "";
                textBox_Search.Font = new Font(textBox_Search.Font, FontStyle.Regular);
                textBox_Search.ForeColor = Color.Black;
            }
        }

        private void textBox_Search_Leave(object sender, System.EventArgs e)
        {
            if (textBox_Search.Text == "")
            {
                textBox_Search.Text = "Input source, destination or duration of flight...";
                textBox_Search.Font = new Font(textBox_Search.Font, FontStyle.Italic);
                textBox_Search.ForeColor = Color.Silver;
            }
        }

        private void button_Search_Click(object sender, System.EventArgs e)
        {
            listBox_Flights.DataSource = _regularUserViewModel.SearchFlights(textBox_Search.Text);
            if (listBox_Flights.Items.Count == 0)
            {
                MessageBox.Show("No flights that meet criteria found.");
            }
        }
    }
}
