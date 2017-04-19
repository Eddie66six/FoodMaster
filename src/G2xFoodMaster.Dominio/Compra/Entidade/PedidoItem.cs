using G2xFoodMaster.Dominio.Compra.Enum;

namespace G2xFoodMaster.Dominio.Compra.Entidade
{
    public class PedidoItem
    {
        #region Construct
        protected PedidoItem()
        {
            
        }

        public PedidoItem(decimal desconto,ETipoDesconto? tipoDesconto,Produto.Entidade.Produto produto)
        {
            Desconto = desconto;
            TipoDeDesconto = tipoDesconto;
            Produto = produto;
            ValorProduto = produto.Valor;
        }
        #endregion

        #region Methods
        public void AdicionarRecebimento(RecebimentoItem recebimentoItem)
        {
            RecebimentoItem = recebimentoItem;
        }
        #endregion
        #region Attr
        public int IdPedidoItem { get; protected set; }
        public decimal Desconto { get; protected set; }
        public ETipoDesconto? TipoDeDesconto { get; protected set; }
        public int IdProduto { get; protected set; }
        public decimal ValorProduto { get; protected set; }
        public virtual Produto.Entidade.Produto Produto { get; protected set; }
        public int IdPedido { get; protected set; }
        public virtual Pedido Pedido { get; protected set; }
        public int? IdRecebimentoItem { get; protected set; }
        public virtual RecebimentoItem RecebimentoItem { get; protected set; }
        #endregion
    }
}