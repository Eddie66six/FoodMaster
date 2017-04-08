using G2xFoodMaster.Dominio.Compra.Enum;

namespace G2xFoodMaster.Dominio.Compra.Entidade
{
    public class RecebimentoItem
    {
        #region Construct
        protected RecebimentoItem()
        {

        }

        public RecebimentoItem(EFormaDePagamento formaDePagamento,EBandeiras? bandeira,PedidoItem pedidoItem)
        {
            FormaDePagamento = formaDePagamento;
            Bandeira = bandeira;
            PedidoItem = pedidoItem;
        }
        #endregion

        #region Methods

        #endregion
        #region MyRegion
        public int IdRecebimentoItem { get; protected set; }
        public bool EstaPago { get; protected set; }
        public EFormaDePagamento FormaDePagamento { get; protected set; }
        public Enum.EBandeiras? Bandeira { get; protected set; }
        public int IdPedidoItem { get; protected set; }
        public virtual PedidoItem PedidoItem { get; protected set; }
        #endregion
    }
}