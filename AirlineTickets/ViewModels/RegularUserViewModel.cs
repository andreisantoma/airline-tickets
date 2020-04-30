using AirlineTickets.Models;
using AirlineTickets.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirlineTickets.ViewModels
{
    public class RegularUserViewModel
    {
        private readonly GenericRepository<Flight> _flightsRepo;

        public RegularUserViewModel(GenericRepository<Flight> flights)
        {
            _flightsRepo = flights;
        }

        public List<string> SearchFlights(string query)
        {
            try
            {
                int duration = Int32.Parse(query);
                // Search by duration

                return _flightsRepo
                    .Get(
                        f => f.Duration <= duration + 15,
                        new List<string> { "Company" })
                    .Select(f => f.ToString())
                    .ToList();
            }
            catch (Exception)
            {
                ;
            }

            List<string> to_return = _flightsRepo
                .Get(
                    f => f.Source.StartsWith(query),
                    new List<string> { "Company" })
                .Select(f => f.ToString())
                .ToList();

            to_return.AddRange(               
                _flightsRepo
                .Get(
                    f => f.Destination.StartsWith(query),
                    new List<string> { "Company" })
                .Select(f => f.ToString())
                .ToList()
                );

            return to_return;
        }
    }
}
