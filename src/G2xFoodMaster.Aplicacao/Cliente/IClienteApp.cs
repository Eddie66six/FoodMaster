using System.Collections.Generic;
using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Compra.Entidade;

namespace G2xFoodMaster.Aplicacao.Cliente
{
    public interface IClienteApp : IBaseApp<Dominio.Cliente.Entidade.Cliente>
    {
        bool Logar(string usuario, string senha);
    }
}