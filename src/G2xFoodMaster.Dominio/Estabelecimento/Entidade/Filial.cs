using System.Collections.Generic;

namespace G2xFoodMaster.Dominio.Estabelecimento.Entidade
{
    public class Filial
    {
        protected Filial()
        {
            
        }

        public Filial(string nome, Estabelecimento estabelecimento)
        {
            Nome = nome;
            Estabelecimento = estabelecimento;
        }

        public int IdFilial { get; protected set; }
        public string Nome { get; protected set; }
        public int IdEstabelecimento { get; protected set; }
        public virtual Estabelecimento Estabelecimento { get; protected set; }
        public virtual List<Produto.Entidade.Produto> Produtos { get; protected set; }
        public List<Funcionario.Entidade.Funcionario> FuncionariosCadastrados { get; set; }
    }
}