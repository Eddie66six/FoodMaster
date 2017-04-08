using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using G2xFoodMaster.Aplicacao.Produto;

namespace G2xFoodMaster.Servico.Controllers.Produto
{
    [Authorize]
    [RoutePrefix("api/v1/produto")]
    public class ProdutoController : BaseController
    {
        private readonly IProdutoApp _produtoApp;
        public ProdutoController(IProdutoApp produtoApp)
        {
            _produtoApp = produtoApp;
        }
        [Route("{idEstabelecimento}/{idFilial}/obterTodos")]
        [HttpGet]
        public Task<HttpResponseMessage> ObterTodos(int idEstabelecimento, int idFilial)
        {
            return CreateResponse(HttpStatusCode.OK, _produtoApp.ObterTodos(idEstabelecimento,idFilial));
        }
    }
}
