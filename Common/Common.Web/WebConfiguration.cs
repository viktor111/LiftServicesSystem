namespace Common.Web
{
    using System;
    using Application.Contracts;
    using FluentValidation.AspNetCore;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.DependencyInjection;
    using Services;

    public static class WebConfiguration
    {
        public static IServiceCollection AddCommonWebComponents(
            this IServiceCollection services,
            Type applicationConfigurationType)
        {
            services
                .AddScoped<ICurrentUser, CurrentUserService>()
                .AddControllers()
                .AddFluentValidation(validation => validation
                    .RegisterValidatorsFromAssemblyContaining(applicationConfigurationType))
                .AddNewtonsoftJson();

            services
                .Configure<ApiBehaviorOptions>(options => options
                    .SuppressModelStateInvalidFilter = true);

            return services;
        }
    }
}
