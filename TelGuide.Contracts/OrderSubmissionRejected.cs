using System;

namespace TelGuide.Contracts
{
    public interface OrderSubmissionRejected
    {
        Guid CorrelationId { get; }
        Guid OrderId { get; }

        string Reason { get; }

        string ReportId { get; }
        string FaultMessage { get; }
        DateTime FaultTime { get; }
    }
}
