using System;

namespace TelGuide.Contracts
{
    public interface IGuideRequestReceivedEvent
    {
        Guid CorrelationId { get; }
        string ReportId { get; }
    }
}
