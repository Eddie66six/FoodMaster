using System.Collections.Generic;
using G2xFoodMaster.Aplicacao._Comun;

namespace G2xFoodMaster.Aplicacao.Produto
{
    public interface IProdutoApp:IBaseApp<Dominio.Produto.Entidade.Produto>
    {
        IEnumerable<Dominio.Produto.Entidade.Produto> ObterTodos(int idFilial);
        IEnumerable<Dominio.Produto.Entidade.Produto> ObterPorNome(int idFilial, string nome);
        IEnumerable<Dominio.Produto.Entidade.Produto> ObterDescricao(int idFilial, string descricao);
    }
}