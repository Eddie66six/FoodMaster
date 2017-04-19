using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using G2xFoodMaster.Aplicacao.Compra;
using G2xFoodMaster.Dominio.Compra.Enum;

namespace G2xFoodMaster.Servico.Controllers.Compra
{
    [Authorize]
    [RoutePrefix("api/v1/pedido")]
    public class PedidoController : BaseController
    {
        private readonly IPedidoApp _pedidoApp;
        public PedidoController(IPedidoApp pedidoApp)
        {
            _pedidoApp = pedidoApp;
        }

        [Route("obterPeidosCliente")]
        [HttpGet]
        public Task<HttpResponseMessage> ObterPedidosCliente(int idCliente, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido = null, int take = 5, int skip = 0)
        {
            return CreateResponse(HttpStatusCode.OK, _pedidoApp.ObterPorIdCliente(idCliente, dataInicio, dataFim, statusDoPedido, take, skip));
        }
        [Route("obterPeidosEstabelecimento")]
        [HttpGet]
        public Task<HttpResponseMessage> ObterPedidosEstabelecimento(int idEstabelecimento, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido = null, int take = 5, int skip = 0)
        {
            return CreateResponse(HttpStatusCode.OK, _pedidoApp.ObterPorIdEstabelecimento(idEstabelecimento, dataInicio, dataFim, statusDoPedido, take, skip));
        }
        [Route("obterPeidosFilial")]
        [HttpGet]
        public Task<HttpResponseMessage> ObterPedidosFilial(int idFilial, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido = null, int take = 5, int skip = 0)
        {
            return CreateResponse(HttpStatusCode.OK, _pedidoApp.ObterPorIdFilial(idFilial, dataInicio, dataFim, statusDoPedido, take, skip));
        }
        [Route("obterPeidosEntregador")]
        [HttpGet]
        public Task<HttpResponseMessage> ObterPedidosEntregador(int idFuncionarioEntregador, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido = null, int take = 5, int skip = 0)
        {
            return CreateResponse(HttpStatusCode.OK, _pedidoApp.ObterPorIdFuncionarioEntregador(idFuncionarioEntregador, dataInicio, dataFim, statusDoPedido, take, skip));
        }
    }
}
