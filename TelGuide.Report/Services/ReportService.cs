using System.Threading;
using System.Threading.Tasks;
using TelGuide.Report.Data;
using TelGuide.Report.Interfaces;

namespace TelGuide.Report.Services
{
    public class ReportService : IReportService
    {
        private readonly IReportDbContext _reportDbContext;
        public ReportService(IReportDbContext reportDbContext)
        {
            _reportDbContext = reportDbContext;
        }

        public async Task Save(CancellationToken cancellationToken)
        {
            _reportDbContext.Reports.Add(new Entities.ReportOutput() { ReportStatus = Entities.ReportStatus.Completed });
            await _reportDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
