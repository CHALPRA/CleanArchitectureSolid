using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureSolid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WithoutCleanArchController : ControllerBase
    {
 #region ocultarcontroller
        [HttpGet("NOSRP")]
        public IEnumerable<string> Get()
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "Juancho";
            empleado.Salario = "$100";
            empleado.Edad = "15años";
            
            return new string[] { empleado.GuardarEnBaseDatos(), empleado.GenerarInforme() };
        }

        [HttpGet("NOOCP/{categoria}")]
        public decimal Get(string categoria)
        {
            CalculadoraDescuentos calculadoraDescuentos = new CalculadoraDescuentos();
            decimal descuento = calculadoraDescuentos.CalcularDescuento(new Producto { Categoria = categoria }, 1000);
            return descuento;
        }
 #endregion

        [HttpGet("NOISP")]
        public IEnumerable<string> GetNoisp()
        {
            Pedido pedido = new Pedido();
            pedido.Cliente = "Juanito";
            ProcesarPedido procesarPedido = new ProcesarPedido();
            return new string[] { procesarPedido.CrearPedido(pedido) };
        }
    }

    internal interface IPedido {
        string CrearPedido(Pedido pedido);
        void ActualizarPedido(Pedido pedido);
        void EliminarPedido(Pedido pedido);

    }

    internal class ProcesarPedido : IPedido
    {
        public string CrearPedido(Pedido pedido)
        {
            return $"Pedido del cliente {pedido.Cliente} Creado.";
        }

        public void ActualizarPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void EliminarPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }

    internal class Pedido
    {
        public string Cliente { get; set; } = string.Empty;
    }

    #region ocultar

    internal class CalculadoraDescuentos {

        public decimal CalcularDescuento(Producto producto, decimal precio) {
            decimal descuento = 0;
            if (producto.Categoria == "Electronicos")
            {
                descuento = precio * 0.1m;
            }
            else if (producto.Categoria == "Ropa") {
                descuento = precio * 0.2m;
            }
            return precio - descuento;
        }
    }

    internal class Producto {
        public string Categoria { get; set; }
    }
    internal class Empleado
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Salario { get; set; }

        public string GuardarEnBaseDatos() {
            return $"Empleado {Nombre} fue registrado en la BBDD";
        }

        public string GenerarInforme()
        {
            return $"Empleado : {Nombre} , Edad : {Edad} ,  Salario : {Salario}";
        }

    }

    #endregion
}
