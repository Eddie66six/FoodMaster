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
        [Route("{idFilial}/obterTodos")]
        [HttpGet]
        public Task<HttpResponseMessage> ObterTodos(int idFilial)
        {
            return CreateResponse(HttpStatusCode.OK, _produtoApp.ObterTodos(idFilial));
        }
        [Route("{idFilial}/obterPorNome/{nome}")]
        [HttpGet]
        public Task<HttpResponseMessage> ObterPorNome(int idFilial, string nome)
        {
            return CreateResponse(HttpStatusCode.OK, _produtoApp.ObterPorNome(idFilial, nome));
        }
    }
}
