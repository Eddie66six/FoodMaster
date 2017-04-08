using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Funcionario.Interface.Servico;

namespace G2xFoodMaster.Aplicacao.Funcionario
{
    public class FuncionarioApp:BaseApp<Dominio.Funcionario.Entidade.Funcionario>,IFuncionarioApp
    {
        private readonly IFuncionarioServico _funcionarioServico;
        public FuncionarioApp(IFuncionarioServico funcionarioServico) : base(funcionarioServico)
        {
            _funcionarioServico = funcionarioServico;
        }

        public bool Logar(string usuario, string senha)
        {
            return _funcionarioServico.Logar(usuario, senha);
        }
    }
}