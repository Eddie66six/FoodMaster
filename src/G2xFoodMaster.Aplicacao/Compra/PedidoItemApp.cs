using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Interface.Servico;

namespace G2xFoodMaster.Aplicacao.Compra
{
    public class PedidoItemApp: BaseApp<PedidoItem>, IPedidoItemApp
    {
        private readonly IPedidoItemServico _pedidoItemServico;
        public PedidoItemApp(IPedidoItemServico pedidoItemServico) : base(pedidoItemServico)
        {
            _pedidoItemServico = pedidoItemServico;
        }
    }
}