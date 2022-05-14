using System;

namespace TelGuide.Contracts
{
    public interface BaseContract
    {
        Guid EventId { get; }
        DateTime Timestamp { get; }
    }
}
