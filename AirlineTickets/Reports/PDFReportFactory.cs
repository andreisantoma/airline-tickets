namespace AirlineTickets.Reports
{
    public class PDFReportFactory : IReportFactory
    {
        public IReport GetReport(string fileName, string path)
        {
            return new PDFReport(fileName, path);
        }
    }
}
