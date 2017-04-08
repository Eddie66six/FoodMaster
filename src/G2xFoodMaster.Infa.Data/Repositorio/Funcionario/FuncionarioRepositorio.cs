using System.Linq;
using G2xFoodMaster.Dominio.Funcionario.Interface.Repositorio;

namespace G2xFoodMaster.Infa.Data.Repositorio.Funcionario
{
    public class FuncionarioRepositorio : _Comun.BaseRepositorio<Dominio.Funcionario.Entidade.Funcionario>, IFuncionarioRepositorio
    {
        public bool Logar(string usuario, string senha)
        {
            return Db.Funcionario.Any(p => p.Login.Usuario == usuario && p.Login.Senha == senha);
        }
    }
}