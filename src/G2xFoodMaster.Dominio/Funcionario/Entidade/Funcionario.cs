using System;
using System.Collections.Generic;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Estabelecimento.Entidade;
using G2xFoodMaster.Dominio.Funcionario.Enum;
using G2xFoodMaster.Dominio._Comun.Entidade;

namespace G2xFoodMaster.Dominio.Funcionario.Entidade
{
    public class Funcionario : Pessoa
    {
        protected Funcionario()
        {
            
        }

        public Funcionario(ETipoFuncionario tipoFuncionario, string nome,string sobrenome, string apelido, string bairro, string cep, string rua,string numero, string complemento, string cidade,
            DateTime dataDeNascimento,Login login,Filial filial)
        {
            TipoDeFuncionario = tipoFuncionario;
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
            Filial = filial;
        }
        #region attr
        public int IdFuncionario { get; protected set; }
        public ETipoFuncionario TipoDeFuncionario { get; protected set; }
        public virtual List<Pedido> PedidosEntregues { get; protected set; }
        public virtual List<Pedido> PedidosCancelados { get; protected set; }
        public virtual List<Pedido> PedidosFeito { get; protected set; }
        public virtual List<Produto.Entidade.Produto> ProdutosCadastrados { get; protected set; }
        public virtual List<Funcionario> FuncionarioCadastrados { get; protected set ;}
        public int IdFilial { get; protected set; }
        public virtual Filial Filial { get; protected set; }
        public int? IdFuncionarioCadastro { get; protected set; }
        public virtual Funcionario FuncionarioCadastro { get; protected set; }
        public virtual List<Cliente.Entidade.Cliente> ClientesCadastrados { get; protected set; }
        #endregion
    }
}
