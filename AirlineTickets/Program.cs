using AirlineTickets.DataAccess;
using AirlineTickets.Models;
using AirlineTickets.Repositories;
using AirlineTickets.ViewModels;
using AirlineTickets.Views;
using System;
using System.Windows.Forms;

namespace AirlineTickets
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var _context = new AirlineTicketsContext();
            
            var _employeesRepo = new GenericRepository<Employee>(_context);
            var _regularUsersRepo = new GenericRepository<RegularUser>(_context);
            var _adminsRepo = new GenericRepository<Administrator>(_context);
            var _flightsRepo = new GenericRepository<Flight>(_context);
            var _companiesRepo = new GenericRepository<Company>(_context);
            
            Application.Run(
                new LoginForm(
                    new LoginViewModel(_employeesRepo, _adminsRepo, _regularUsersRepo),
                    new AdminViewModel(_regularUsersRepo, _companiesRepo, _employeesRepo, _flightsRepo),
                    new EmployeeViewModel(_flightsRepo, _employeesRepo),
                    new RegularUserViewModel(_flightsRepo)
                    )
                );
        }
    }
}
