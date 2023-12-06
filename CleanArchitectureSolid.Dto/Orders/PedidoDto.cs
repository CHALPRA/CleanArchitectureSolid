namespace CleanArchitectureSolid.Dtos.Orders
{
    public class PedidoDto
    {
        public string Id { get; set; }
        public string Cliente { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Estado { get; set;} = string.Empty;
        public DateTime FechaPedido { get; set; }
    }
}
