using System;

namespace TelGuide.Contracts
{
    public interface IGuideFailedEvent
    {
        Guid CorrelationId { get; }
        string ReportId { get; }
    }
}
