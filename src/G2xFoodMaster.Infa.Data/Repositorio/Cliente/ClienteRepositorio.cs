using System.Collections.Generic;
using System.Linq;
using G2xFoodMaster.Dominio.Cliente.Interface.Repositorio;

namespace G2xFoodMaster.Infa.Data.Repositorio.Cliente
{
    public class ClienteRepositorio : _Comun.BaseRepositorio<Dominio.Cliente.Entidade.Cliente>, IClienteRepositorio
    {
        public IEnumerable<Dominio.Cliente.Entidade.Cliente> ObterPorNome(string nome)
        {
            return Db.Cliente.Where(p => p.Nome.Contains(nome)).ToList();
        }
    }
}