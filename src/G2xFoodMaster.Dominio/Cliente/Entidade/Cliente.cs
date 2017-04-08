using System;
using System.Collections.Generic;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio._Comun.Entidade;

namespace G2xFoodMaster.Dominio.Cliente.Entidade
{
    public class Cliente : Pessoa
    {
        #region Constructor
        protected Cliente()
        {
            
        }
        public Cliente(string nome, string sobrenome, string apelido, string bairro, string cep, string rua, string numero, string complemento, string cidade,
            DateTime dataDeNascimento, Login login, Funcionario.Entidade.Funcionario funcionarioCadastro)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Apelido = apelido;
            Bairro = bairro;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            DataDeNascimento = dataDeNascimento;
            Login = login;
            FuncionarioCadastro = funcionarioCadastro;
        }
        #endregion
        #region attr
        public int IdCliente { get; protected set; }
        public virtual List<Pedido> Pedidos { get; protected set; }
        public int IdFuncionarioCadastro { get; protected set; }
        public virtual Funcionario.Entidade.Funcionario FuncionarioCadastro { get; protected set; }
        #endregion
    }
}
