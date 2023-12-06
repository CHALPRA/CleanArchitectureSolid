using CleanArchitectureSolid.Entities.Interfaces;
using CleanArchitectureSolid.UseCases.InputPorts.Birds;
using CleanArchitectureSolid.UseCases.InputPorts.Employees;
using CleanArchitectureSolid.UseCases.InputPorts.Orders;
using CleanArchitectureSolid.UseCases.InputPorts.Products;
using CleanArchitectureSolid.UseCases.Interactors.Birds;
using CleanArchitectureSolid.UseCases.Interactors.Employees;
using CleanArchitectureSolid.UseCases.Interactors.Orders;
using CleanArchitectureSolid.UseCases.Interactors.Products;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureSolid.UseCases
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUseCasesServices(
            this IServiceCollection services)
        {
            services.AddTransient<IGeneraInformeInputPort, GeneraInformeInteractor>();
            services.AddTransient<ICalculaDescuentoInputPort, CalculaDescuentoInteractor>();
            services.AddTransient<IAveSonidoInputPort, AveSonidoInteractor>();
            services.AddTransient<IProcesarOrderInputPort, ProcesarOrderInteractor>();
            services.AddTransient<IGenerarPedido, GenerarPedidoServices>();
            
            return services;
        }
    }
}
