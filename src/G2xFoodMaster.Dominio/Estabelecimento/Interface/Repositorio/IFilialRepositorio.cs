using System.Collections.Generic;
using G2xFoodMaster.Dominio._Comun.Interface.Repositorio;

namespace G2xFoodMaster.Dominio.Estabelecimento.Interface.Repositorio
{
    public interface IFilialRepositorio : IBaseRepositorio<Entidade.Filial>
    {
        IEnumerable<Entidade.Filial> ObterPorIdEstabelecimento(int idEstabelecimento);
    }
}