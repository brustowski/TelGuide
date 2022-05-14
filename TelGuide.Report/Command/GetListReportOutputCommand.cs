using System.Collections.Generic;
using MediatR;
using TelGuide.Report.Entities;

namespace TelGuide.Report.Command
{
    public class GetListReportOutputCommand : IRequest<List<ReportOutput>>
    {
        public List<ReportOutput> ReportOutputs { get; set; }
    }
}
