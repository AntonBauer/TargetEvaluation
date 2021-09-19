using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TargetEvaluation.Cli.Options;
using TargetEvaluation.ImageProcessing.ImageProcessors;

namespace TargetEvaluation.Cli
{
    internal class TargetEvaluationService : IHostedService
    {
        private readonly ILogger _logger;
        private readonly TargetEvaluationOptions _evalOptions;
        private readonly IImageProcessor _imageProcessor;

        public TargetEvaluationService(
            ILogger<TargetEvaluationService> logger,
            IOptions<TargetEvaluationOptions> evalOptions,
            IImageProcessor imageProcessor)
        {
            _logger = logger;
            _imageProcessor = imageProcessor;
            _evalOptions = evalOptions.Value;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Started evaluation");
            
            _imageProcessor.ParseImage(_evalOptions.ImagePath);
            
            return ValueTask.CompletedTask.AsTask();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Stopped");
            return ValueTask.CompletedTask.AsTask();
        }
    }
}