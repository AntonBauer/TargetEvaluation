using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TargetEvaluation.Cli
{
    class Program
    {
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();
        
        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
               .ConfigureServices((context, services) =>
                    services
                       .AddHostedService<TargetEvaluationService>()
                       .Configure<TargetEvaluationOptions>(context.Configuration)
                );
    }
}