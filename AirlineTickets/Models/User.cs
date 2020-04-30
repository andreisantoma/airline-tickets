using System.ComponentModel.DataAnnotations;

namespace AirlineTickets.Models
{
    public abstract class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return "Username:" + this.Username + " Password:" + this.Password;
        }
    }
}
