using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TargetEvaluation.Cli.Options;
using TargetEvaluation.ImageProcessing;

namespace TargetEvaluation.Cli
{
    internal static class Program
    {
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
               .ConfigureServices((context, services) =>
                    services
                       .AddHostedService<TargetEvaluationService>()
                       .Configure<TargetEvaluationOptions>(context.Configuration.GetSection(TargetEvaluationOptions.ConfigSection))
                       .AddImageProcessing()
                );

    }
}