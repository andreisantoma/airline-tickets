using AirlineTickets.Models;
using AirlineTickets.Reports;
using AirlineTickets.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirlineTickets.ViewModels
{
    public class AdminViewModel
    {
        private readonly GenericRepository<RegularUser> _regularUsersRepo;
        private readonly GenericRepository<Company> _companiesRepo;
        private readonly GenericRepository<Employee> _employeeRepo;
        private readonly GenericRepository<Flight> _flightsRepo;

        public AdminViewModel(GenericRepository<RegularUser> regularUsersRepo,
            GenericRepository<Company> companiesRepo,
            GenericRepository<Employee> employeesRepo,
            GenericRepository<Flight> flightsRepo)
        {
            _regularUsersRepo = regularUsersRepo;
            _companiesRepo = companiesRepo;
            _employeeRepo = employeesRepo;
            _flightsRepo = flightsRepo;
        }

        public IList<RegularUser> GetRegularUsers()
        {
            return _regularUsersRepo.GetAll().ToList();
        }

        public IList<Company> GetCompanies()
        {
            return _companiesRepo.GetAll().ToList();
        }

        public bool AddRegularUser(string username, string password)
        {
            if (_regularUsersRepo.Get(u => u.Username == username).ToList().Count != 0)
            {
                // Username taken
                return false;
            }
            if (username == "" || password == "")
            {
                return false;
            }
            else
            {
                _regularUsersRepo.Insert(new RegularUser
                {
                    Username = username,
                    Password = password
                });
                _regularUsersRepo.Save();
                return true;
            }
        }

        public bool DeleteRegularUser(int regularUserId)
        {
            if (regularUserId == -1)
            {
                return false;
            }
            else
            {
                _regularUsersRepo.Delete(regularUserId);
                _regularUsersRepo.Save();
                return true;
            }
        }

        public (string, string) GetRegularUserInfo(int regularUserId)
        {
            var u = _regularUsersRepo.GetById(regularUserId);
            return (u.Username, u.Password);
        }

        public bool UpdateRegularUser(int regularUserId, string username, string password)
        {
            if (regularUserId == -1)
            {
                return false;
            }
            if (username == "" || password == "")
            {
                return false;
            }
            if (_regularUsersRepo.Get(u => u.Username == username).ToList().Count != 0)
            {
                // Username taken
                return false;
            }

            var regularUser = _regularUsersRepo.GetById(regularUserId);
            regularUser.Username = username;
            regularUser.Password = password;
            _regularUsersRepo.Update(regularUser);
            _regularUsersRepo.Save();
            return true;
        }

        public string GetCompanyName(int companyId)
        {
            return _companiesRepo.GetById(companyId).Name;
        }

        public bool AddCompany(string name)
        {
            if (name == "")
            {
                return false;
            }
            else
            {
                _companiesRepo.Insert(new Company { Name = name });
                _companiesRepo.Save();
                return true;
            }
        }

        public bool DeleteCompany(int companyId)
        {
            if (companyId == -1)
            {
                return false;
            }
            else;
            {
                _companiesRepo.Delete(companyId);
                _companiesRepo.Save();
                return true;
            }
        }

        public bool UpdateCompany(int companyId, string name)
        {
            if (companyId == -1 || name == "")
            {
                return false;
            }
            else
            {
                var c = _companiesRepo.GetById(companyId);
                c.Name = name;
                _companiesRepo.Update(c);
                _companiesRepo.Save();
                return true;
            }
        }

        public bool AddEmployee(int companyId, string username, string password)
        {
            if (companyId == -1 || username == "" || password == "")
            {
                return false;
            }
            if (_employeeRepo.Get(u => u.Username == username).ToList().Count != 0)
            {
                // Username taken
                return false;
            }

            var c = _companiesRepo.GetById(companyId);
            var e = new Employee
            {
                Company = c,
                Username = username,
                Password = password
            };

            _employeeRepo.Insert(e);
            _employeeRepo.Save();
            return true;
        }

        public bool GenerateReport(string path, string fileName, string type)
        {
            if (path == "" || fileName == "")
            {
                return false;
            }

            IReportFactory rf;

            if (type == "txt")
            {
                rf = new TextReportFactory();
            }
            else if (type == "pdf")
            {
                rf = new PDFReportFactory();
            }
            else
            {
                return false;
            }

            IReport report = rf.GetReport(fileName, path);
            List<Flight> flights = _flightsRepo.Get(includeProperties : new List<string> { "Company" }).ToList();
            report.Open();            
            foreach (var flight in flights)
            {
                report.WriteFlight(flight);
            }
            report.Close();

            return true;
        }
    }
}
