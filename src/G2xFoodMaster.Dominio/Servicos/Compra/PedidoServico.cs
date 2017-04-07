using G2xFoodMaster.Dominio.Compra.Interface.Repositorio;
using G2xFoodMaster.Dominio.Compra.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Compra
{
    public class PedidoServico : BaseServico<Dominio.Compra.Entidade.Pedido>, IPedidoServico
    {
        private readonly IPedidoRepositorio _repositorio;
        public PedidoServico(IPedidoRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}