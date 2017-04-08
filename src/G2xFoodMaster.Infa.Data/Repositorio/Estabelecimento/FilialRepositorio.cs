using System.Collections.Generic;
using System.Linq;
using G2xFoodMaster.Dominio.Estabelecimento.Entidade;
using G2xFoodMaster.Dominio.Estabelecimento.Interface.Repositorio;

namespace G2xFoodMaster.Infa.Data.Repositorio.Estabelecimento
{
    public class FilialRepositorio : _Comun.BaseRepositorio<Filial>, IFilialRepositorio
    {
        public IEnumerable<Filial> ObterPorIdEstabelecimento(int idEstabelecimento)
        {
            return Db.Filial.Where(p => p.IdEstabelecimento == idEstabelecimento).ToList();
        }
    }
}