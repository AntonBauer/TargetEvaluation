﻿using Microsoft.Extensions.DependencyInjection;
using TargetEvaluation.ImageProcessing.ImageProcessors;

namespace TargetEvaluation.ImageProcessing
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddImageProcessing(this IServiceCollection services)
        {
            services.AddTransient<IImageProcessor, ImageProcessor>();
            return services;
        }
    }
}