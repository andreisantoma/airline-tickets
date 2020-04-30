using AirlineTickets.Models;
using AirlineTickets.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace AirlineTickets.ViewModels
{
    public class LoginViewModel
    {
        private readonly GenericRepository<Employee> _employeesRepo;
        private readonly GenericRepository<Administrator> _adminsRepo;
        private readonly GenericRepository<RegularUser> _usersRepo;

        public LoginViewModel(
            GenericRepository<Employee> employeesRepo,
            GenericRepository<Administrator> adminsRepo,
            GenericRepository<RegularUser> usersRepo)
        {
            _employeesRepo = employeesRepo;
            _adminsRepo = adminsRepo;
            _usersRepo = usersRepo;
        }

        public bool LoginAsEmployee(string username, string password)
        {
            List<Employee> L = _employeesRepo.Get(e => e.Username == username).ToList();

            if (L.Count != 1)
            {
                return false;
            }
            else
            {
                if (L[0].Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool LoginAsAdministrator(string username, string password)
        {
            List<Administrator> L = _adminsRepo.Get(a => a.Username == username).ToList();

            if (L.Count != 1)
            {
                return false;
            }
            else
            {
                if (L[0].Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool LoginAsRegularUser(string username, string password)
        {
            List<RegularUser> L = _usersRepo.Get(u => u.Username == username).ToList();

            if (L.Count != 1)
            {
                return false;
            }
            else
            {
                if (L[0].Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
