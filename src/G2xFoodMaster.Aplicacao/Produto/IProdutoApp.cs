using System.Collections.Generic;
using G2xFoodMaster.Aplicacao._Comun;

namespace G2xFoodMaster.Aplicacao.Produto
{
    public interface IProdutoApp:IBaseApp<Dominio.Produto.Entidade.Produto>
    {
        IEnumerable<Dominio.Produto.Entidade.Produto> ObterTodos(int idEstabelecimento, int idFilial);
    }
}