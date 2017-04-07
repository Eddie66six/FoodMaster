using G2xFoodMaster.Dominio.Funcionario.Interface.Repositorio;
using G2xFoodMaster.Dominio.Funcionario.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Funcionario
{
    public class FuncionarioServico : BaseServico<Dominio.Funcionario.Entidade.Funcionario>,IFuncionarioServico
    {
        private readonly IFuncionarioRepositorio _repositorio;
        public FuncionarioServico(IFuncionarioRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}