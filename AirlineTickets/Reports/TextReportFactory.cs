namespace AirlineTickets.Reports
{
    public class TextReportFactory : IReportFactory
    {
        public IReport GetReport(string fileName, string path)
        {
            return new TextReport(fileName, path);
        }
    }
}
