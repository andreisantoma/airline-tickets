using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using AirlineTickets.Models;

namespace AirlineTickets.Reports
{
    public class PDFReport : IReport
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        private FileStream _fs;
        private Document _document;
        private PdfWriter _pdfWriter;
        private PdfPTable _pdfPTable;

        public PDFReport(string fileName, string path)
        {
            FileName = fileName;
            Path = path;
        }

        public void Close()
        {
            _document.Add(_pdfPTable);
            _document.Close();
            _pdfWriter.Close();
            _fs.Close();
        }

        public void Open()
        {
            _fs = new FileStream(Path + "\\" + FileName + ".pdf", FileMode.Create);
            _document = new Document(PageSize.A4, 25, 25, 30, 30);
            _pdfWriter = PdfWriter.GetInstance(_document, _fs);
            _document.Open();

            _pdfPTable = new PdfPTable(5);
            _pdfPTable.AddCell("Flight id");
            _pdfPTable.AddCell("Company");
            _pdfPTable.AddCell("Source");
            _pdfPTable.AddCell("Destination");
            _pdfPTable.AddCell("Duration (mins)");
        }

        public void WriteLine(string text)
        {
            throw new System.NotImplementedException();
        }

        public void WriteFlight(Flight f)
        {
            _pdfPTable.AddCell(f.Id.ToString());
            _pdfPTable.AddCell(f.Company.Name);
            _pdfPTable.AddCell(f.Source);
            _pdfPTable.AddCell(f.Destination);
            _pdfPTable.AddCell(f.Duration.ToString());
        }
    }
}
