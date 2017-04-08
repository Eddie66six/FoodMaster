using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using G2xFoodMaster.Aplicacao.Cliente;

namespace G2xFoodMaster.Servico.Controllers.Cliente
{
    [RoutePrefix("api/v1/cliente")]
    public class ClienteController : BaseController
    {
        private readonly IClienteApp _clienteApp;
        public ClienteController(IClienteApp clienteApp)
        {
            _clienteApp = clienteApp;
        }
        [Route("obterTodos")]
        [HttpGet]
        public Task<HttpResponseMessage> ObterTodos()
        {
            return CreateResponse(HttpStatusCode.OK, _clienteApp.GetAll());
        }
    }
}
