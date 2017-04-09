using System;
using System.Collections.Generic;
using System.Linq;
using G2xFoodMaster.Dominio.Compra.Enum;

namespace G2xFoodMaster.Dominio.Compra.Entidade
{
    public class Pedido
    {
        #region Contruct
        protected Pedido()
        {
            DataDoPedido = DateTime.Now;
            StatusDoPedido = EStatusDoPedido.Aberto;
        }

        public Pedido(Cliente.Entidade.Cliente cliente)
        {
            Cliente = cliente;
            DataDoPedido = DateTime.Now;
            StatusDoPedido = EStatusDoPedido.Aberto;
        }
        #endregion

        #region Methods

        public void AdicionarItens(List<PedidoItem> itens, Funcionario.Entidade.Funcionario funcionarioPedido)
        {
            ItensDoPedido = itens;
        }

        public void DefinirEntregador(Funcionario.Entidade.Funcionario funcionarioEntregador)
        {
            FuncionarioEntregador = funcionarioEntregador;
        }

        public string ObterTitulosConcatenados(char separador)
        {
            return ItensDoPedido.Aggregate("", (current, item) => current + (item.Produto.Titulo + separador.ToString())).TrimEnd(separador);
        }

        public decimal ObterValorDaCompra()
        {
            return
                ItensDoPedido.Sum(
                    p =>
                        p.ValorProduto -
                        (p.TipoDeDesconto == ETipoDesconto.Dinheiro ? p.Desconto : (p.ValorProduto * p.Desconto / 100)));
        }

        public decimal ObterValorDeDescontoNaCompra()
        {
            return
                ItensDoPedido.Sum(
                    p => p.TipoDeDesconto == ETipoDesconto.Dinheiro ? p.Desconto : (p.ValorProduto*p.Desconto/100));
        }
        #endregion

        #region Attr
        public int IdPedido { get; protected set; }
        public DateTime DataDoPedido { get; protected set; }
        public EStatusDoPedido StatusDoPedido { get; protected set; }
        public TimeSpan? HoraDaEntrega { get; protected set; }
        public int IdCliente { get; protected set; }
        public virtual Cliente.Entidade.Cliente Cliente { get; protected set; }
        public virtual List<PedidoItem> ItensDoPedido { get; protected set; }
        public int? IdFuncionarioEntregador { get; protected set; }
        public virtual Funcionario.Entidade.Funcionario FuncionarioEntregador { get; protected set; }
        public bool Cancelado { get; protected set; }
        public DateTime? DataDeCancelamento { get; protected set; }
        public int? IdFuncionarioCancelamento { get; protected set; }
        public virtual Funcionario.Entidade.Funcionario FuncionarioCancelamento { get; protected set; }
        public int? IdFuncionarioPedido { get; protected set; }
        public virtual Funcionario.Entidade.Funcionario FuncionarioPedido { get; protected set; }
        #endregion
    }
}