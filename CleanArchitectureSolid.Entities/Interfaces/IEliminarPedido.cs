namespace CleanArchitectureSolid.Entities.Interfaces
{
    public interface IEliminarPedido
    {
        bool EliminarPedidoById(int id);
        bool EliminarPedidoByReference(string nroReferencia);
    }
}
