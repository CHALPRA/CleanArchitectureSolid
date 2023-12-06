using CleanArchitectureSolid.Dtos.Products;

namespace CleanArchitectureSolid.UseCases.OutputPorts.Products
{
    public interface ICalculaDescuentoOutputPort
    {
        Task Handle(ProductoDescuentoDto outputDto);
    }
}
