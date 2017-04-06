using System;

namespace G2xFoodMaster.Dominio._Comun.Entidade
{
    public class Base
    {
        public DateTime DataDeCadastro { get; protected set; }
        public int? IdFuncionarioCadastro { get; protected set; }
        public virtual Funcionario.Entidade.Funcionario FuncionarioCadastro { get; protected set; }
    }
}