using CleanArchitectureSolid.Entities.Entities;
using CleanArchitectureSolid.Entities.Interfaces;

namespace CleanArchitectureSolid.UseCases.Interactors.Orders
{
    internal class GenerarPedidoServices : IGenerarPedido
    {
        public Pedido CrearPedido(string tipo, string cliente)
        {
            return new Pedido
            {
                Id = new Random().Next(),
                NroReferencia = "#ORD_" + (new Random().Next(10, 20)).ToString("D8"),
                Tipo = tipo,
                Cliente = cliente,
                Estado = "CREADO"
            };
        }

        public bool ValidarPedido(Pedido pedido)
        {
            return !string.IsNullOrEmpty(pedido.NroReferencia)
                   && pedido.Estado.Equals("CREADO")
                   && !string.IsNullOrEmpty(pedido.Cliente);
        }
    }
}
