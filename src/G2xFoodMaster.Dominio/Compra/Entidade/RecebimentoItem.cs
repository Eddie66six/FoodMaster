namespace G2xFoodMaster.Dominio.Compra.Entidade
{
    public class RecebimentoItem
    {
        public int IdRecebimentoItem { get; protected set; }
        public bool EstaPago { get; protected set; }
        public Enum.EFormaDePagamento FormaDePagamento { get; protected set; }
        public Enum.EBandeiras? Bandeira { get; protected set; }
        public int IdPedidoItem { get; protected set; }
        public virtual PedidoItem PedidoItem { get; protected set; }
    }
}