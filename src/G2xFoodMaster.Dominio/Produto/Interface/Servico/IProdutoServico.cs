using System.Collections.Generic;
using G2xFoodMaster.Dominio._Comun.Interface.Servico;

namespace G2xFoodMaster.Dominio.Produto.Interface.Servico
{
    public interface IProdutoServico : IBaseServico<Entidade.Produto>
    {
        IEnumerable<Entidade.Produto> ObterTodos(int idEstabelecimento, int idFilial);
    }
}