using System.Collections.Generic;
using System.Linq;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Interface.Repositorio;

namespace G2xFoodMaster.Infa.Data.Repositorio.Compra
{
    public class PedidoItemRepositorio : _Comun.BaseRepositorio<Dominio.Compra.Entidade.PedidoItem>, IPedidoItemRepositorio
    {
        public IEnumerable<PedidoItem> ObterPorIdPedido(int idPedido)
        {
            return Db.PedidoItem.Where(p => p.IdPedido == idPedido).ToList();
        }
    }
}