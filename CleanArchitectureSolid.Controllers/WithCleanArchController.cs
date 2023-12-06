using CleanArchitectureSolid.Dtos.Orders;
using CleanArchitectureSolid.Presenters.Interfaces;
using CleanArchitectureSolid.UseCases.InputPorts.Birds;
using CleanArchitectureSolid.UseCases.InputPorts.Employees;
using CleanArchitectureSolid.UseCases.InputPorts.Orders;
using CleanArchitectureSolid.UseCases.InputPorts.Products;
using CleanArchitectureSolid.UseCases.OutputPorts.Birds;
using CleanArchitectureSolid.UseCases.OutputPorts.Employees;
using CleanArchitectureSolid.UseCases.OutputPorts.Orders;
using CleanArchitectureSolid.UseCases.OutputPorts.Products;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureSolid.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WithCleanArchController : ControllerBase
    {
        #region ports
        private readonly IGeneraInformeInputPort _generaInformeInputPort;
        private readonly IGeneraInformeOutputPort _generaInformeOutputPort;

        private readonly ICalculaDescuentoInputPort _calculaDescuentoInputPort;
        private readonly ICalculaDescuentoOutputPort _calculaDescuentoOutputPort;

        private readonly IAveSonidoInputPort _aveSonidoInputPort;
        private readonly IAveSonidoOutputPort _aveSonidoOutputPort;
        #endregion

        private readonly IProcesarOrderInputPort _procesarOrderInputPort;
        private readonly IProcesarOrderOutputPort _procesarOrderOutputPort;

        public WithCleanArchController(IGeneraInformeInputPort generaInformeInputPort,
            IGeneraInformeOutputPort generaInformeOutputPort,
            ICalculaDescuentoInputPort calculaDescuentoInputPort,
            ICalculaDescuentoOutputPort calculaDescuentoOutputPort,
            IAveSonidoInputPort aveSonidoInputPort,
            IAveSonidoOutputPort aveSonidoOutputPort,
            IProcesarOrderInputPort procesarOrderInputPort,
            IProcesarOrderOutputPort procesarOrderOutputPort
            )
        {
            _generaInformeInputPort = generaInformeInputPort;
            _generaInformeOutputPort = generaInformeOutputPort;
            _calculaDescuentoInputPort = calculaDescuentoInputPort;
            _calculaDescuentoOutputPort = calculaDescuentoOutputPort;
            _aveSonidoInputPort = aveSonidoInputPort;
            _aveSonidoOutputPort =  aveSonidoOutputPort;
            _procesarOrderInputPort = procesarOrderInputPort;
            _procesarOrderOutputPort = procesarOrderOutputPort;
        }

        #region principios

        [HttpGet("SRP")]
        public async Task<IEnumerable<string>> Get()
        {
            await _generaInformeInputPort.Handle("Juan Andrade");
            string informe = ((IPresenter<string>)_generaInformeOutputPort).Content;
            return new string[] { "Principio de responsabilidad unica", informe };
        }


        [HttpGet("OCP/{categoria}")]
        public async Task<IEnumerable<string>> Get(string categoria)
        {
            await _calculaDescuentoInputPort.Handle(categoria);
            string descuento = ((IPresenter<string>)_calculaDescuentoOutputPort).Content;
            return new string[] { "Principio Abierto/Cerrado", descuento };
        }

        [HttpGet("LSP")]
        public async Task<IEnumerable<string>> GetLSP()
        {
            await _aveSonidoInputPort.Handle();
            List<string> sonidos = ((IPresenter<List<string>>)_aveSonidoOutputPort).Content;
            List<string> response = new()
            {
                "Principio de Sustitución de Liskov "
            };
            response.AddRange(sonidos);
            return response;
        }
        #endregion

        [HttpGet("ISP")]
        public async Task<IEnumerable<string>> GetISP()
        {
            await _procesarOrderInputPort.Handle(new SolicitudPedidoDto { 
              Cliente = "Perico",
              Pedido = "Hamburguesa"
            });
            string ordenProcesada = ((IPresenter<string>)_procesarOrderOutputPort).Content;
            return new string[] { "Principio Segregacion de interfaces", ordenProcesada };
        }


    }
}
