namespace CleanArchitectureSolid.UseCases.InputPorts.Products
{
    public interface ICalculaDescuentoInputPort
    {
        Task Handle(string categoria);
    }
}
