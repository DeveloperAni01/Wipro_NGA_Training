using WiproSolidAssignment.Services;
using WiproSolidAssignment.Repositories;
using WiproSolidAssignment.Formatters;
using WiproSolidAssignment.Factories;

class Program
{
    static void Main()
    {
        // SRP
        var generator = new ReportGenerator();
        var repository = new FileReportRepository();
        var service = new ReportService(repository);

        string report = generator.Generate();

        // OCP
        var formatter = new PdfFormatter();
        string formattedReport = formatter.Format(report);

        // DIP
        service.Process(formattedReport);

        Console.WriteLine("Report Processed Successfully");

        // Factory Pattern
        var document = DocumentFactory.Create("pdf");
        document.Open();
    }
}