using Microsoft.Extensions.Logging;

namespace TargetEvaluation.ImageProcessing.ImageProcessors
{
    internal sealed class ImageProcessor : IImageProcessor
    {
        private readonly ILogger _logger;

        public ImageProcessor(ILogger<ImageProcessor> logger)
        {
            _logger = logger;
        }

        public void ParseImage(string imagePath)
        {
            _logger.LogInformation("Processing image {ImagePath}", imagePath);
        }
    }
}