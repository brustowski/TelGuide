using System;

namespace TelGuide.Contracts
{
    public interface OrderSubmissionAccepted
    {
        string ReportId { get; }
        Guid CorrelationId { get; }
    }
}
