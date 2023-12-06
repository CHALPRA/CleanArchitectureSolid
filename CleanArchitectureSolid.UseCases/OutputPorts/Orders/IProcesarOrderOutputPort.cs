using CleanArchitectureSolid.Dtos.Orders;

namespace CleanArchitectureSolid.UseCases.OutputPorts.Orders
{
    public interface IProcesarOrderOutputPort
    {
        Task Handle(PedidoDto outputDto);
    }
}
