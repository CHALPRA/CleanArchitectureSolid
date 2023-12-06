using CleanArchitectureSolid.Dtos.Products;
using CleanArchitectureSolid.Entities.Entities;
using CleanArchitectureSolid.Entities.Interfaces;
using CleanArchitectureSolid.UseCases.Fabrics;
using CleanArchitectureSolid.UseCases.InputPorts.Products;
using CleanArchitectureSolid.UseCases.OutputPorts.Products;

namespace CleanArchitectureSolid.UseCases.Interactors.Products
{
    internal class CalculaDescuentoInteractor : ICalculaDescuentoInputPort
    {
        private readonly ICalculaDescuentoOutputPort _outputPort;

        public CalculaDescuentoInteractor(ICalculaDescuentoOutputPort outputPort)
        {
            _outputPort = outputPort;
        }
        public Task Handle(string categoria)
        {
            Producto producto = new()
            { 
                Categoria = categoria,
                Nombre = "ProductoSolid"
            };

            ICalculoDescuento calculoDescuento = FabricaDescuento.ObtenerCalculoDescuento(producto);
            decimal descuento = calculoDescuento.CalcularDescuento(producto, 1500);

            return _outputPort.Handle(new ProductoDescuentoDto
            {
                Categoria = producto.Categoria,
                Nombre = producto.Nombre,
                Descuento = descuento
            });
        }
    }
}
