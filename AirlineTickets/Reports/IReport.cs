using AirlineTickets.Models;

namespace AirlineTickets.Reports
{
    public interface IReport
    {
        void Open();
        void Close();
        void WriteFlight(Flight f);
    }
}
