namespace CleanArchitectureSolid.UseCases.OutputPorts.Birds
{
    public interface IAveSonidoOutputPort
    {
        Task Handle(List<string> output);
    }
}
