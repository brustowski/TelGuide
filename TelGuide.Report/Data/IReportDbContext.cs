using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TelGuide.Report.Entities;

namespace TelGuide.Report.Data
{
    public interface IReportDbContext
    {
        DbSet<ReportOutput> Reports { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
