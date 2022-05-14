using System.Threading;
using System.Threading.Tasks;

namespace TelGuide.Report.Interfaces
{
    public interface IReportService
    {
        Task Save(CancellationToken cancellationToken);
    }
}
