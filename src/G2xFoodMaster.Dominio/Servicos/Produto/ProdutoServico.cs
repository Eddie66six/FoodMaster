using G2xFoodMaster.Dominio.Produto.Interface.Repositorio;
using G2xFoodMaster.Dominio.Produto.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Produto
{
    public class ProdutoServico : BaseServico<Dominio.Produto.Entidade.Produto>,IProdutoServico
    {
        private readonly IProdutoRepositorio _repositorio;
        public ProdutoServico(IProdutoRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}