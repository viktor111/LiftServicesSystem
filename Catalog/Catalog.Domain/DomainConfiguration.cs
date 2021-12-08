namespace Catalog.Domain
{
    using Common.Domain;
    using Microsoft.Extensions.DependencyInjection;
    using System.Reflection;

    public static class DomainConfiguration
    {
        public static IServiceCollection AddDomain(
           this IServiceCollection services)
           => services
               .AddCommonDomain(
                   Assembly.GetExecutingAssembly());
    }
}
