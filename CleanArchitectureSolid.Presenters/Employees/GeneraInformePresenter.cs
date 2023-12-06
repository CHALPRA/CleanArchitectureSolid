using CleanArchitectureSolid.Dtos.Employees;
using CleanArchitectureSolid.Presenters.Interfaces;
using CleanArchitectureSolid.UseCases.OutputPorts.Employees;

namespace CleanArchitectureSolid.Presenters.Employees
{
    public class GeneraInformePresenter : IGeneraInformeOutputPort,IPresenter<string>
    {
        public string Content { get ; private set ; }

        public Task Handle(InformeEmpleadoDto outputDto)
        {
            Content = $"Infome del Empleado : {outputDto.Nombre} , Edad : {outputDto.Edad} , Salario $/. : {outputDto.Salario}"; ;
            return Task.CompletedTask;
        }
    }
}
