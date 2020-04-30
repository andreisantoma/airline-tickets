using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirlineTickets.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Flight> Flights { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
