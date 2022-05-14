using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TelGuide.Report.Command;
using TelGuide.Report.Data;
using TelGuide.Report.Entities;

namespace TelGuide.Report.Handler
{
    public class GetListOrderCommandHandler : IRequestHandler<GetListReportOutputCommand, List<ReportOutput>>
    {
        private readonly IReportDbContext _context;

        public GetListOrderCommandHandler(IReportDbContext context)
        {
            _context = context;
        }

        public async Task<List<ReportOutput>> Handle(GetListReportOutputCommand request, CancellationToken cancellationToken)
        {
            return await _context.Reports.ToListAsync();
        }
    }
}
