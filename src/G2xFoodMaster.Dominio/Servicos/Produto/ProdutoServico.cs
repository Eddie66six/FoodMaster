using System.Collections.Generic;
using G2xFoodMaster.Dominio.Produto.Interface.Repositorio;
using G2xFoodMaster.Dominio.Produto.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Produto
{
    public class ProdutoServico : BaseServico<Dominio.Produto.Entidade.Produto>,IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoServico(IProdutoRepositorio produtoRepositorio) : base(produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IEnumerable<Dominio.Produto.Entidade.Produto> ObterDescricao(int idFilial, string descricao)
        {
            return _produtoRepositorio.ObterDescricao(idFilial, descricao);
        }

        public IEnumerable<Dominio.Produto.Entidade.Produto> ObterPorNome(int idFilial, string nome)
        {
            return _produtoRepositorio.ObterPorNome(idFilial, nome);
        }

        public IEnumerable<Dominio.Produto.Entidade.Produto> ObterTodos(int idFilial)
        {
            return _produtoRepositorio.ObterTodos(idFilial);
        }
    }
}