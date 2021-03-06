using System;
using System.Threading;
using System.Threading.Tasks;
using MassTransit;
using TelGuide.Contracts;
using TelGuide.Report.Interfaces;

namespace TelGuide.Report.Consumers
{
    public sealed class PersonConsumer : IConsumer<PersonDto>
    {
        private readonly IReportService _reportService;
        public PersonConsumer(IReportService reportService)
        {
            _reportService = reportService;
        }

        public async Task Consume(ConsumeContext<PersonDto> context)
        {
            PersonDto data = context.Message;
            if (data == null)
            {
                throw new InvalidOperationException("The person was not valid");
            }
            await _reportService.Save(new CancellationTokenSource().Token);
        }
    }
}
