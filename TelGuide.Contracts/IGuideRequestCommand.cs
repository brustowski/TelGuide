using System;

namespace TelGuide.Contracts
{
    public interface IGuideRequestCommand
    {
        string ReportId { get; set; }
        DateTime RequestTime { get; set; }
    }
}
