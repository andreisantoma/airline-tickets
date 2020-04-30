namespace AirlineTickets.Reports
{
    public interface IReportFactory
    {
        IReport GetReport(string fileName, string path);
    }
}
