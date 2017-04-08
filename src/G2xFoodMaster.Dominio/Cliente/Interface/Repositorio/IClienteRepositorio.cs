using System.Collections.Generic;
using G2xFoodMaster.Dominio._Comun.Interface.Repositorio;

namespace G2xFoodMaster.Dominio.Cliente.Interface.Repositorio
{
    public interface IClienteRepositorio : IBaseRepositorio<Entidade.Cliente>
    {
        IEnumerable<Entidade.Cliente> ObterPorNome(string nome);
    }
}