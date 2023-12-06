using CleanArchitectureSolid.Entities.Entities;
using CleanArchitectureSolid.Entities.Interfaces;
using CleanArchitectureSolid.UseCases.InputPorts.Birds;
using CleanArchitectureSolid.UseCases.OutputPorts.Birds;

namespace CleanArchitectureSolid.UseCases.Interactors.Birds
{
    internal class AveSonidoInteractor : IAveSonidoInputPort
    {
        private readonly IAveSonidoOutputPort _outputPort;

        public AveSonidoInteractor(IAveSonidoOutputPort outputPort)
        {
            _outputPort = outputPort;
        }

        public Task Handle()
        {
            List<string> sonidosAve = new List<string>();
            IAve aveLoro = new Loro();
            IAve avePaloma = new Paloma();
            Loro loro = new Loro();
            Paloma paloma = new Paloma();
            sonidosAve.Add("[CLASE LORO]           | " + loro.EmiteSonido());
            sonidosAve.Add("[CLASE PALOMA]         | " + paloma.EmiteSonido());
            sonidosAve.Add("[SUSTITUCION INTERFAZ] | " + aveLoro.EmiteSonido());
            sonidosAve.Add("[SUSTITUCION INTERFAZ] | " + avePaloma.EmiteSonido());
            return _outputPort.Handle(sonidosAve);
        }
    }
}
