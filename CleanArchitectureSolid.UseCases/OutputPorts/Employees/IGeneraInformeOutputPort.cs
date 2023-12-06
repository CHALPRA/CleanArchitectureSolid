using CleanArchitectureSolid.Dtos.Employees;

namespace CleanArchitectureSolid.UseCases.OutputPorts.Employees
{
    public interface IGeneraInformeOutputPort
    {
        Task Handle(InformeEmpleadoDto outputDto);
    }
}
