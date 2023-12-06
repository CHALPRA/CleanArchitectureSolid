using CleanArchitectureSolid.Presenters;
using CleanArchitectureSolid.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureSolid.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddIoC(
            this IServiceCollection services)
        {
            services.AddUseCasesServices();
            services.AddPresenters();
            return services;
        }   
    }
}