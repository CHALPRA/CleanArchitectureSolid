using CleanArchitectureSolid.Entities.Interfaces;

namespace CleanArchitectureSolid.Entities.Entities
{
    public class CalculoDescuentoElectronico : ICalculoDescuento
    {
        public decimal CalcularDescuento(Producto producto, decimal precio)
        {
            return precio - (precio * 0.1m);
        }
    }
}
