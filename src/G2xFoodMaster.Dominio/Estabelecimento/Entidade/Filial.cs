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


        public string Cep { get; protected set; }
        public string Rua { get; protected set; }
        public string Bairro { get; protected set; }
        public string Cidade { get; protected set; }
        public string Numero { get; protected set; }
        public string Complemento { get; protected set; }
        public string Referencia { get; set; }
        public int IdFilial { get; protected set; }
        public string Nome { get; protected set; }
        public int IdEstabelecimento { get; protected set; }
        public virtual Estabelecimento Estabelecimento { get; protected set; }
        public virtual List<Produto.Entidade.Produto> Produtos { get; protected set; }
        public List<Funcionario.Entidade.Funcionario> FuncionariosCadastrados { get; set; }
    }
}