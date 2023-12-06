namespace CleanArchitectureSolid.UseCases.InputPorts.Employees
{
    public interface IGeneraInformeInputPort
    {
        Task Handle(string nombre);
    }
}
