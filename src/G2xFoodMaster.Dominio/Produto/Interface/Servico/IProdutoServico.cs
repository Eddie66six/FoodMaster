using System.Collections.Generic;
using G2xFoodMaster.Dominio._Comun.Interface.Servico;

namespace G2xFoodMaster.Dominio.Produto.Interface.Servico
{
    public interface IProdutoServico : IBaseServico<Entidade.Produto>
    {
        IEnumerable<Entidade.Produto> ObterTodos(int idFilial);
        IEnumerable<Entidade.Produto> ObterPorNome(int idFilial, string nome);
        IEnumerable<Entidade.Produto> ObterDescricao(int idFilial, string descricao);
    }
}