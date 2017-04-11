using System.Collections.Generic;
using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Produto.Interface.Servico;

namespace G2xFoodMaster.Aplicacao.Produto
{
    public class ProdutoApp:BaseApp<Dominio.Produto.Entidade.Produto>,IProdutoApp
    {
        private readonly IProdutoServico _produtoServico;
        public ProdutoApp(IProdutoServico produtoServico) : base(produtoServico)
        {
            _produtoServico = produtoServico;
        }

        public IEnumerable<Dominio.Produto.Entidade.Produto> ObterDescricao(int idFilial, string descricao)
        {
            return _produtoServico.ObterDescricao(idFilial, descricao);
        }

        public IEnumerable<Dominio.Produto.Entidade.Produto> ObterPorNome(int idFilial, string nome)
        {
            return _produtoServico.ObterPorNome(idFilial, nome);
        }

        public IEnumerable<Dominio.Produto.Entidade.Produto> ObterTodos(int idFilial)
        {
            return _produtoServico.ObterTodos(idFilial);
        }
    }
}