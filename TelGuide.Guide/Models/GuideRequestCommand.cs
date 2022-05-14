using System;
using TelGuide.Contracts;

namespace TelGuide
{
    public class GuideRequestCommand : IGuideRequestCommand
    {
        public string ReportId { get; set; }
        public DateTime RequestTime { get; set; }
    }
}
