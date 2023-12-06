namespace CleanArchitectureSolid.Entities.Entities
{
    public class Pedido
    {
        public int Id { get; set; } 
        public string NroReferencia { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Cliente { get; set; } = string.Empty;
    }
}
