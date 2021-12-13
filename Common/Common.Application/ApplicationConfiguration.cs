namespace Common.Application
{
    using System.Reflection;
    using Behaviours;
    using Settings;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Configuration;
    using Common.Application.Mapping;

    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddCommonApplication(
            this IServiceCollection services,
            IConfiguration configuration,
            Assembly assembly)
            => services
                .Configure<ApplicationSettings>(
                    configuration.GetSection(nameof(ApplicationSettings)),
                    options => options.BindNonPublicProperties = true)
                .AddMediatR(assembly)
                .AddAutoMapper(assembly)
                .AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
    }
}
