namespace AirlineTickets.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public Company Company { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Duration { get; set; }

        public override string ToString()
        {
            if (Company == null)
            {
                return "What";
            }
            return "Company: " + Company.Name + "; Source: " + Source + "; Destination: " + Destination + "; Duration: " + Duration + " min.";
        }
    }
}
