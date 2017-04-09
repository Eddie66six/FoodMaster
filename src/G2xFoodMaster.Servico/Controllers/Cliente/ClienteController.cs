using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using G2xFoodMaster.Aplicacao.Cliente;
using G2xFoodMaster.Aplicacao.Compra;
using G2xFoodMaster.Dominio.Compra.Enum;

namespace G2xFoodMaster.Servico.Controllers.Cliente
{
    [Authorize]
    [RoutePrefix("api/v1/cliente")]
    public class ClienteController : BaseController
    {
        private readonly IClienteApp _clienteApp;
        private readonly IPedidoApp _pedidoApp;
        public ClienteController(IClienteApp clienteApp, IPedidoApp pedidoApp)
        {
            _clienteApp = clienteApp;
            _pedidoApp = pedidoApp;
        }
        [Route("obterTodos")]
        [HttpGet]
        public Task<HttpResponseMessage> ObterTodos()
        {
            return CreateResponse(HttpStatusCode.OK, _clienteApp.ObterTodos());
        }
        [Route("obterPeidos")]
        [HttpGet]
        public Task<HttpResponseMessage> ObterPedidos(int idCliente,DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido)
        {
            return CreateResponse(HttpStatusCode.OK, _pedidoApp.ObterPorIdCliente(idCliente,dataInicio,dataFim,statusDoPedido));
        }
    }
}
