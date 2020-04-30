using AirlineTickets.Models;
using System.IO;

namespace AirlineTickets.Reports
{
    public class TextReport : IReport
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        private StreamWriter _sw;

        public TextReport(string fileName, string path)
        {
            FileName = fileName;
            Path = path;
        }

        public void Close()
        {
            _sw.Close();
        }

        public void Open()
        {
            _sw = new StreamWriter(Path + "\\" + FileName + ".txt");
            _sw.WriteLine("Id  Company  Source  Destination  Duration(mins)");
        }

        public void WriteLine(string text)
        {
            _sw.WriteLine(text);
        }

        public void WriteFlight(Flight f)
        {
            _sw.WriteLine(
                f.Id.ToString() + " " +
                f.Company.Name + " " +
                f.Source + " " +
                f.Destination + " " +
                f.Duration.ToString()
                );
        }
    }
}
