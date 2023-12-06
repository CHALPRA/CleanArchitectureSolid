using CleanArchitectureSolid.Dtos.Orders;
using CleanArchitectureSolid.Entities.Entities;
using CleanArchitectureSolid.Entities.Interfaces;
using CleanArchitectureSolid.UseCases.InputPorts.Orders;
using CleanArchitectureSolid.UseCases.OutputPorts.Orders;

namespace CleanArchitectureSolid.UseCases.Interactors.Orders
{
    internal class ProcesarOrderInteractor : IProcesarOrderInputPort
    {
        private readonly IProcesarOrderOutputPort _outputPort;
        private readonly IGenerarPedido _generarPedido;

        public ProcesarOrderInteractor(IProcesarOrderOutputPort outputPort, 
            IGenerarPedido generarPedido)
        {
            _outputPort = outputPort;
            _generarPedido = generarPedido;
        }

        public Task Handle(SolicitudPedidoDto inputDto)
        {
            Pedido nuevoPedido = _generarPedido.CrearPedido(inputDto.Pedido, 
                inputDto.Cliente);
            return _outputPort.Handle(new PedidoDto { 
                   Id = nuevoPedido.NroReferencia,
                   Tipo = nuevoPedido.Tipo,
                   Cliente = nuevoPedido.Cliente,
                   Estado = nuevoPedido.Estado,
                   FechaPedido = DateTime.Now,
            });
        }
    }
}
