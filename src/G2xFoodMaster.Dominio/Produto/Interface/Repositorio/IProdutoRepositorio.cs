using System.Collections.Generic;
using G2xFoodMaster.Dominio._Comun.Interface.Repositorio;

namespace G2xFoodMaster.Dominio.Produto.Interface.Repositorio
{
    public interface IProdutoRepositorio : IBaseRepositorio<Entidade.Produto>
    {
        IEnumerable<Entidade.Produto> ObterTodos(int idFilial);
        IEnumerable<Entidade.Produto> ObterPorNome(int idFilial,string nome);
        IEnumerable<Entidade.Produto> ObterDescricao(int idFilial, string descricao);
    }
}