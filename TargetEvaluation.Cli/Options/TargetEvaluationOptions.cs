namespace TargetEvaluation.Cli.Options
{
    internal record TargetEvaluationOptions
    {
        public const string ConfigSection = "EvalOptions";
        
        public string ImagePath { get; set; }
    }
}