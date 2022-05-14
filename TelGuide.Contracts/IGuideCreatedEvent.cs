using System;

namespace TelGuide.Contracts
{
    public interface IGuideCreatedEvent
    {
        Guid CorrelationId { get; }
        string ReportId { get; }
    }
}
