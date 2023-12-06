using CleanArchitectureSolid.Dtos.Orders;
using CleanArchitectureSolid.Presenters.Interfaces;
using CleanArchitectureSolid.UseCases.OutputPorts.Orders;

namespace CleanArchitectureSolid.Presenters.Orders
{
    internal class ProcesarOrderPresenter : IProcesarOrderOutputPort, IPresenter<string>
    {
        public string Content { get; private set; }

        public Task Handle(PedidoDto outputDto)
        {
            Content = $"El Pedido {outputDto.Id} de {outputDto.Tipo } fue {outputDto.Estado} correctamente para el cliente {outputDto.Cliente} a las {outputDto.FechaPedido}"; ;
            return Task.CompletedTask;
        }
    }
}
