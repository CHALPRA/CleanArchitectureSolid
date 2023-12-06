using CleanArchitectureSolid.Presenters.Interfaces;
using CleanArchitectureSolid.UseCases.OutputPorts.Birds;

namespace CleanArchitectureSolid.Presenters.Birds
{
    internal class AveSonidoPresenter : IAveSonidoOutputPort, IPresenter<List<string>>
    {
        public List<string> Content { get; private set;  }

        public Task Handle(List<string> output)
        {
            Content = output;
            return Task.CompletedTask;
        }
    }
}
