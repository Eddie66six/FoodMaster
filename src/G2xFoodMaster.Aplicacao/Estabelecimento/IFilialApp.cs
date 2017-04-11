using System.Collections.Generic;
using G2xFoodMaster.Aplicacao.Estabelecimento.ViewModel;
using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Estabelecimento.Entidade;

namespace G2xFoodMaster.Aplicacao.Estabelecimento
{
    public interface IFilialApp:IBaseApp<Filial>
    {
        IEnumerable<Filial> ObterPorIdEstabelecimento(int idEstabelecimento);
        IEnumerable<FilialDetalheViewModel> ObterPorNome(string nome, string cidade);
    }
}