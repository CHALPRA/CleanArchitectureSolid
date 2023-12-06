using CleanArchitectureSolid.Entities.Interfaces;

namespace CleanArchitectureSolid.Entities.Entities
{
    public class CalculoDescuentoRopa : ICalculoDescuento
    {
        public decimal CalcularDescuento(Producto producto, decimal precio)
        {
            return precio - (precio * 0.2m);
        }
    }
}
