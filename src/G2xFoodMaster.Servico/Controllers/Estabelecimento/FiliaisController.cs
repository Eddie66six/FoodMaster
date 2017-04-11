using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using G2xFoodMaster.Aplicacao.Estabelecimento;

namespace G2xFoodMaster.Servico.Controllers.Estabelecimento
{
    [Authorize]
    [RoutePrefix("api/v1/estabelecimento")]
    public class FiliaisController : BaseController
    {
        private readonly IFilialApp _filialApp;
        public FiliaisController(IFilialApp filialApp)
        {
            _filialApp = filialApp;
        }

        [Route("obterEstabelecimentos")]
        [HttpGet]
        public Task<HttpResponseMessage> ObterEstabelecimentos(string nome, string cidade)
        {
            return CreateResponse(HttpStatusCode.OK, _filialApp.ObterPorNome(nome,cidade));
        }
    }
}
