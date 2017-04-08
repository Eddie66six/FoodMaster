using G2xFoodMaster.Dominio._Comun.Interface.Servico;

namespace G2xFoodMaster.Dominio.Funcionario.Interface.Servico
{
    public interface IFuncionarioServico : IBaseServico<Entidade.Funcionario>
    {
        bool Logar(string usuario, string senha);
    }
}