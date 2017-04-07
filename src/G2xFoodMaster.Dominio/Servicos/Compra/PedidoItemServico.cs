using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Interface.Repositorio;
using G2xFoodMaster.Dominio.Compra.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Compra
{
    public class PedidoItemServico : BaseServico<PedidoItem>, IPedidoItemServico
    {
        private readonly IPedidoItemRepositorio _repositorio;
        public PedidoItemServico(IPedidoItemRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}