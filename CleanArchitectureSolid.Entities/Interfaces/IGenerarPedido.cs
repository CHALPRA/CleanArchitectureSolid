using CleanArchitectureSolid.Entities.Entities;

namespace CleanArchitectureSolid.Entities.Interfaces
{
    public interface IGenerarPedido
    {
        bool ValidarPedido(Pedido pedido);
        Pedido CrearPedido(string tipo, string cliente);
    }
}
