using System;
using G2xFoodMaster.Dominio.Funcionario.Interface.Repositorio;
using G2xFoodMaster.Dominio.Funcionario.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Funcionario
{
    public class FuncionarioServico : BaseServico<Dominio.Funcionario.Entidade.Funcionario>,IFuncionarioServico
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;
        public FuncionarioServico(IFuncionarioRepositorio funcionarioRepositorio) : base(funcionarioRepositorio)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }

        public bool Logar(string usuario, string senha)
        {
            return _funcionarioRepositorio.Logar(usuario, senha);
        }
    }
}