using CleanArchitectureSolid.Dtos.Orders;

namespace CleanArchitectureSolid.UseCases.InputPorts.Orders
{
    public interface IProcesarOrderInputPort
    {
        Task Handle(SolicitudPedidoDto inputDto);
    }
}
