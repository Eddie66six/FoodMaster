using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;
using G2xFoodMaster.Aplicacao.Cliente;
using G2xFoodMaster.Aplicacao.Funcionario;

namespace G2xFoodMaster.Servico.Controllers.Usuario
{
    [Authorize]
    [RoutePrefix("api/v1/auth")]
    public class UsuarioController : BaseController
    {
        private readonly IClienteApp _clienteApp;
        private readonly IFuncionarioApp _funcionarioApp;
        public UsuarioController(IClienteApp clienteApp, IFuncionarioApp funcionarioApp)
        {
            _clienteApp = clienteApp;
            _funcionarioApp = funcionarioApp;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("cliente/login")]
        public Task<HttpResponseMessage> LoginCliente(string usuario, string senha)
        {
            if (!_clienteApp.Logar(usuario, senha))
                return null;

            var identity = new ClaimsIdentity("Bearer");
            //var principal = new GenericPrincipal(identity, usuario.Permissoes.ToArray());
            //identity.AddClaims(principal.Claims);

            var ticket = ConfigureAuthenticationTicket(identity);
            var token = Startup.OAuthServerOptions.AccessTokenFormat.Protect(ticket);
            return CreateResponse(HttpStatusCode.OK, new Aplicacao._Comun.ViewModel.LoginViewModel { Autorizado = true, Token = token });
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("funcionario/login")]
        public Task<HttpResponseMessage> LoginFuncionario(string usuario, string senha)
        {
            if (!_funcionarioApp.Logar(usuario, senha))
                return null;

            var identity = new ClaimsIdentity("Bearer");
            identity.AddClaim(new Claim("teste", "teste"));
            //var principal = new GenericPrincipal(identity, usuario.Permissoes.ToArray());
            //identity.AddClaims(principal.Claims);

            var ticket = ConfigureAuthenticationTicket(identity);
            var token = Startup.OAuthServerOptions.AccessTokenFormat.Protect(ticket);
            return CreateResponse(HttpStatusCode.OK, new Aplicacao._Comun.ViewModel.LoginViewModel { Autorizado = true, Token = token });
        }
    }
}
