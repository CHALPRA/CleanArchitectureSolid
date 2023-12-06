using CleanArchitectureSolid.IoC;

namespace CleanArchitectureSolid.WebApi.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddIoc(IServiceCollection services) {
            services.AddIoC();
            return services;
        }
    }
}
