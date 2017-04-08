using System.Collections.Generic;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Estabelecimento.Entidade;
using G2xFoodMaster.Dominio._Comun.Entidade;

namespace G2xFoodMaster.Dominio.Produto.Entidade
{
    public class Produto : Base
    {
        protected Produto()
        {
            
        }

        public Produto(string codigo, string titulo, string descricao, decimal valor, string urlImagem, Filial filial)
        {
            Codigo = codigo;
            Titulo = titulo;
            Descricao = descricao;
            Valor = valor;
            UrlImagem = urlImagem;
            Filial = filial;
        }
        public int IdProduto { get; protected set; }
        public string Codigo { get; protected set; }
        public string Titulo { get; protected set; }
        public string Descricao { get; protected set; }
        public decimal Valor { get; protected set; }
        public string UrlImagem { get; protected set; }
        public virtual List<PedidoItem> PedidoItems { get; protected set; }
        public int IdFilial { get; protected set; }
        public virtual Filial Filial { get; protected set; }
        public int IdFuncionarioCadastro { get; protected set; }
        public virtual Funcionario.Entidade.Funcionario FuncionarioCadastro { get; protected set; }
    }
}