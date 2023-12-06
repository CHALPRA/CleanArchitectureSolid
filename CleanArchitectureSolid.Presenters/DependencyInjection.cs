using CleanArchitectureSolid.Presenters.Birds;
using CleanArchitectureSolid.Presenters.Employees;
using CleanArchitectureSolid.Presenters.Orders;
using CleanArchitectureSolid.Presenters.Products;
using CleanArchitectureSolid.UseCases.OutputPorts.Birds;
using CleanArchitectureSolid.UseCases.OutputPorts.Employees;
using CleanArchitectureSolid.UseCases.OutputPorts.Orders;
using CleanArchitectureSolid.UseCases.OutputPorts.Products;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureSolid.Presenters
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresenters(
            this IServiceCollection services)
        {
            services.AddScoped<IGeneraInformeOutputPort, GeneraInformePresenter>();
            services.AddScoped<ICalculaDescuentoOutputPort, ProductoDescuentoPresenter>();
            services.AddScoped<IAveSonidoOutputPort, AveSonidoPresenter>();
            services.AddScoped<IProcesarOrderOutputPort, ProcesarOrderPresenter>();            
            return services;
        }
    }
}
