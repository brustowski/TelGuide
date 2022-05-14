using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TelGuide.Report.Command;
using TelGuide.Report.Data;
using TelGuide.Report.Entities;

namespace TelGuide.Report.Handler
{
    public class GetOrderCommandHandler : IRequestHandler<GetReportOutputCommand, ReportOutput>
    {
        private readonly IReportDbContext _context;

        public GetOrderCommandHandler(IReportDbContext context)
        {
            _context = context;
        }

        public async Task<ReportOutput> Handle(GetReportOutputCommand request, CancellationToken cancellationToken)
        {
            return await _context.Reports.FindAsync(new object[] { request.Id });
        }
    }
}
