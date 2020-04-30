using AirlineTickets.Models;
using AirlineTickets.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirlineTickets.ViewModels
{
    public class EmployeeViewModel
    {
        private readonly GenericRepository<Flight> _flightsRepo;
        private readonly GenericRepository<Employee> _employeesRepo;
        private Employee _employee;

        public EmployeeViewModel(GenericRepository<Flight> flightsRepo, GenericRepository<Employee> employeesRepo)
        {
            _flightsRepo = flightsRepo;
            _employeesRepo = employeesRepo;
        }

        public void SetCurrentEmploye(string username)
        {
            _employee = _employeesRepo.Get(e => e.Username == username, new List<string> { "Company" }).ToList()[0];
        }

        public List<Flight> GetFlights()
        {
            return _flightsRepo.Get(f => f.Company.Id == _employee.Company.Id, new List<string> { "Company" }).ToList();
        }

        public (string, string, string) GetFlightInfo(int flightId)
        {
            Flight f = _flightsRepo.GetById(flightId);
            return (f.Source, f.Destination, f.Duration.ToString());
        }

        public bool AddFlight(string source, string destination, string duration)
        {
            if (source == destination || source == "" || destination == "")
            {
                return false;
            }

            int _duration;
            try
            {
                _duration = Int32.Parse(duration);
            }
            catch (Exception)
            {
                return false;
            }
            if (_duration <= 0)
            {
                return false;
            }

            _flightsRepo.Insert(new Flight
            {
                Source = source,
                Destination = destination,
                Duration = _duration,
                Company = _employee.Company
            });
            _flightsRepo.Save();
            return true;
        }

        public bool DeleteFlight(int flightId)
        {
            if (flightId == -1)
            {
                return false;
            }
            else
            {
                _flightsRepo.Delete(flightId);
                _flightsRepo.Save();
                return true;
            }
        }

        public bool UpdateFlight(int flightId, string source, string destination, string duration)
        {
            if (flightId == -1)
            {
                return false;
            }

            if (source == destination || source == "" || destination == "")
            {
                return false;
            }

            int _duration;
            try
            {
                _duration = Int32.Parse(duration);
            }
            catch (Exception)
            {
                return false;
            }
            if (_duration <= 0)
            {
                return false;
            }

            Flight f = _flightsRepo.GetById(flightId);
            f.Source = source;
            f.Destination = destination;
            f.Duration = _duration;

            _flightsRepo.Update(f);
            _flightsRepo.Save();
            return true;
        }
    }
}
