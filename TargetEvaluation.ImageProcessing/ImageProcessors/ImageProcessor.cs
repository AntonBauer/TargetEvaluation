using System;
using System.IO;
using Microsoft.Extensions.Logging;
using OpenCvSharp;

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
            EnsureImageExists(imagePath);

            using var image = new Mat(imagePath);
            FindRings();
            FindBulletHoles();
        }

        private void EnsureImageExists(string imagePath)
        {
            if (File.Exists(imagePath)) return;
            
            _logger.LogError("File {ImagePath} does not exists", imagePath);
            throw new ArgumentException($"File {imagePath} does not exists");
        }
        
        private void FindRings(){}
        
        private void FindBulletHoles(){}
    }
}