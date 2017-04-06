using System;

namespace G2xFoodMaster.Dominio.Compra.Entidade
{
    public class PedidoItem
    {
        public int IdPedidoItem { get; protected set; }
        public DateTime DataDoPedido { get; protected set; }
        public TimeSpan HoraDaEntrega { get; set; }
        public decimal Desconto { get; protected set; }
        public Enum.ETipoDesconto? TipoDeDesconto { get; protected set; }
        public int IdProduto { get; protected set; }
        public virtual Produto.Entidade.Produto Produto { get; protected set; }
        public int IdPedido { get; protected set; }
        public virtual Pedido Pedido { get; protected set; }
        public int IdRecebimentoItem { get; protected set; }
        public virtual RecebimentoItem RecebimentoItem { get; protected set; }
    }
}