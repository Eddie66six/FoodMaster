using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Interface.Servico;

namespace G2xFoodMaster.Aplicacao.Compra
{
    public class PedidoApp:BaseApp<Pedido>,IPedidoApp
    {
        private readonly IPedidoServico _pedidoServico;
        public PedidoApp(IPedidoServico pedidoServico) : base(pedidoServico)
        {
            _pedidoServico = pedidoServico;
        }
    }
}