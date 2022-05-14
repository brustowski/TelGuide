using MediatR;
using TelGuide.Report.Entities;

namespace TelGuide.Report.Command
{
    public class GetReportOutputCommand : IRequest<ReportOutput>
    {
        public long Id { get; set; }
    }
}
