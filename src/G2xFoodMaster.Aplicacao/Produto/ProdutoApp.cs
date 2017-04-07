using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Produto.Interface.Servico;

namespace G2xFoodMaster.Aplicacao.Produto
{
    public class ProdutoApp:BaseApp<Dominio.Produto.Entidade.Produto>,IProdutoApp
    {
        private readonly IProdutoServico _produtoServico;
        public ProdutoApp(IProdutoServico produtoServico) : base(produtoServico)
        {
        }
    }
}