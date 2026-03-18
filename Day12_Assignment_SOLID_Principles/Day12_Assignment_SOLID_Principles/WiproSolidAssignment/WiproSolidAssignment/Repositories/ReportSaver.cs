using System.IO;
using WiproSolidAssignment.Interfaces;

namespace WiproSolidAssignment.Repositories
{
    public class FileReportRepository : IReportRepository
    {
        public void Save(string content)
        {
            File.WriteAllText("report.txt", content);
        }
    }
}