using WiproSolidAssignment.Interfaces;

namespace WiproSolidAssignment.Services
{
    public class ReportService
    {
        private readonly IReportRepository _repository;

        public ReportService(IReportRepository repository)
        {
            _repository = repository;
        }

        public void Process(string content)
        {
            _repository.Save(content);
        }
    }
}