using MassTransit;
using System.Threading.Tasks;
using TelGuide.Contracts;

namespace TelGuide.Report.Consumers
{
    public sealed class SubmitTokenConsumer : IConsumer<SubmitToken>
    {
        public SubmitTokenConsumer()
        {
        }

        public async Task Consume(ConsumeContext<SubmitToken> context)
        {
            if (context.Message.Token.Contains("TEST"))
            {
                if (context.RequestId != null)
                    await context.RespondAsync<TokenRejected>(new
                    {
                        context.Message.EventId,
                        InVar.Timestamp,
                        Token = context.Message.Token,
                        Reason = $"Test cannot submit token: {context.Message.Token}"
                    });

                return;
            }

            if (context.RequestId != null)
            {
                await context.RespondAsync<TokenAccepted>(new
                {
                    context.Message.EventId,
                    InVar.Timestamp,
                });
            }
        }
    }
}
