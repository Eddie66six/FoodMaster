using System.Collections.Generic;
using System.Web.Http;
using G2xFoodMaster.Aplicacao.Cliente;

namespace G2xFoodMaster.Servico.Controllers.Cliente
{
    [RoutePrefix("api/v1/cliente")]
    public class ClienteController : ApiController
    {
        private readonly IClienteApp _clienteApp;
        public ClienteController(IClienteApp clienteApp)
        {
            _clienteApp = clienteApp;
        }
        [Route("/obterTodos")]
        [HttpGet]
        public IEnumerable<Dominio.Cliente.Entidade.Cliente> ObterTodos()
        {
            return _clienteApp.GetAll();
        }
    }
}
