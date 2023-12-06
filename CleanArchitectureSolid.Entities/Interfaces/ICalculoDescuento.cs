using CleanArchitectureSolid.Entities.Entities;

namespace CleanArchitectureSolid.Entities.Interfaces
{
    public interface ICalculoDescuento
    {
        decimal CalcularDescuento(Producto producto, decimal precio);
    }
}
