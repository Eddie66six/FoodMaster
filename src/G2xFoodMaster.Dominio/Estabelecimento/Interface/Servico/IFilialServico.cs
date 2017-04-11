using System.Collections.Generic;
using G2xFoodMaster.Dominio._Comun.Interface.Servico;

namespace G2xFoodMaster.Dominio.Estabelecimento.Interface.Servico
{
    public interface IFilialServico : IBaseServico<Entidade.Filial>
    {
        IEnumerable<Entidade.Filial> ObterPorIdEstabelecimento(int idEstabelecimento);
        IEnumerable<Entidade.Filial> ObterPorNome(string nome, string cidade);
    }
}