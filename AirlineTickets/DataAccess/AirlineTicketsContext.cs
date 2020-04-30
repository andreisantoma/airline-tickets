using AirlineTickets.Models;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace AirlineTickets.DataAccess
{
    public class AirlineTicketsContext : DbContext
    {
        public AirlineTicketsContext() : base("AirlineTicketsContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new AirlineTicketsContextInitializer(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }

        public IDbSet<RegularUser> RegularUsers{ get; set; }
        public IDbSet<Employee> Employees { get; set; }
        public IDbSet<Administrator> Administrators { get; set; }
        public IDbSet<Company> Companies { get; set; }
        public IDbSet<Flight> Flights { get; set; }
    }

    public class AirlineTicketsContextInitializer : SqliteDropCreateDatabaseAlways<AirlineTicketsContext>
    {
        public AirlineTicketsContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder)
        {

           modelBuilder
               .Entity<Flight>()
               .HasRequired(f => f.Company)
               .WithMany(c => c.Flights);
           
           modelBuilder
               .Entity<Employee>()
               .HasRequired(e => e.Company)
               .WithMany(c => c.Employees);
        }

        protected override void Seed(AirlineTicketsContext context)
        {
            Company company1 = new Company
            {
                Name = "Qatar"
            };

            Company company2 = new Company
            {
                Name = "Blue Air"
            };

            Flight flight1 = new Flight
            {
                Company = company1,
                Source = "Bucharest",
                Destination = "Cluj-Napoca",
                Duration = 60
            };

            Flight flight2 = new Flight
            {
                Company = company1,
                Source = "London",
                Destination = "Berlin",
                Duration = 200
            };

            RegularUser regularUser1 = new RegularUser
            {
                Username = "mike",
                Password = "mike"
            };

            RegularUser regularUser2 = new RegularUser
            {
                Username = "george",
                Password = "george"
            };

            Employee employee1 = new Employee
            {
                Username = "tom",
                Password = "tom",
                Company = company1
            };

            Employee employee2 = new Employee
            {
                Username = "john",
                Password = "john",
                Company = company2
            };

            Administrator administrator1 = new Administrator
            {
                Username = "pablo",
                Password = "pablo"
            };

            context.Flights.Add(flight1);
            context.Flights.Add(flight2);

            context.Companies.Add(company1);
            context.Companies.Add(company2);

            context.RegularUsers.Add(regularUser1);
            context.RegularUsers.Add(regularUser2);
            context.Employees.Add(employee1);
            context.Employees.Add(employee2);
            context.Administrators.Add(administrator1);
        }
    }


}
