using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace TargetEvaluation.Cli
{
    internal class TargetEvaluationService : IHostedService
    {
        private readonly ILogger _logger;
        private readonly TargetEvaluationOptions _options;

        public TargetEvaluationService(
            ILogger<TargetEvaluationService> logger,
            IOptions<TargetEvaluationOptions> options)
        {
            _logger = logger;
            _options = options.Value;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Started evaluation");
            return ValueTask.CompletedTask.AsTask();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Stopped");
            return ValueTask.CompletedTask.AsTask();
        }
    }
}