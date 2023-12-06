using CleanArchitectureSolid.Entities.Entities;
using CleanArchitectureSolid.Entities.Interfaces;

namespace CleanArchitectureSolid.UseCases.Fabrics
{
    public class FabricaDescuento
    {
        public static ICalculoDescuento ObtenerCalculoDescuento(Producto producto) {
            if (producto.Categoria == "Electronicos") {
                return new CalculoDescuentoElectronico();
            } else if (producto.Categoria == "Ropa") {
                return new CalculoDescuentoRopa();
            }
            return new CalculoDescuentoTemporada();
        }
    }
}
