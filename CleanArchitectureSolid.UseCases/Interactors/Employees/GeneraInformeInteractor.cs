using CleanArchitectureSolid.Dtos.Employees;
using CleanArchitectureSolid.Entities.Entities;
using CleanArchitectureSolid.UseCases.InputPorts.Employees;
using CleanArchitectureSolid.UseCases.OutputPorts.Employees;

namespace CleanArchitectureSolid.UseCases.Interactors.Employees
{
    internal class GeneraInformeInteractor : IGeneraInformeInputPort
    {
        private readonly IGeneraInformeOutputPort _outputPort;

        public GeneraInformeInteractor(IGeneraInformeOutputPort outputPort)
        {
            _outputPort = outputPort;
        }

        public Task Handle(string nombre)
        {
            Empleado empleado = new Empleado
            {
                Nombre = nombre,
                Edad = 25,
                Salario = 1500
            };

            return _outputPort.Handle(new InformeEmpleadoDto
            {
                Nombre = empleado.Nombre,
                Edad = empleado.Edad,
                Salario = empleado.Salario
            });
        }
    }
}
