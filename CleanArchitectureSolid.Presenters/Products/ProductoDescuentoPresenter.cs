using CleanArchitectureSolid.Dtos.Products;
using CleanArchitectureSolid.Presenters.Interfaces;
using CleanArchitectureSolid.UseCases.OutputPorts.Products;

namespace CleanArchitectureSolid.Presenters.Products
{
    internal class ProductoDescuentoPresenter : ICalculaDescuentoOutputPort, IPresenter<string>
    {
        public string Content { get; private set; }

        public Task Handle(ProductoDescuentoDto outputDto)
        {
            Content = $"Descuento del producto: {outputDto.Nombre} , en la categoria : {outputDto.Categoria} , es $/. : {outputDto.Descuento}"; ;
            return Task.CompletedTask;
        }
    }
}
