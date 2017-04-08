using System.Collections.Generic;
using System.Linq;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Interface.Repositorio;

namespace G2xFoodMaster.Infa.Data.Repositorio.Compra
{
    public class RecebimentoItemRepositorio : _Comun.BaseRepositorio<RecebimentoItem>, IRecebimentoItemRepositorio
    {
        public IEnumerable<RecebimentoItem> ObterPorIdCliente(int idCliente)
        {
            return Db.RecebimentoItem.Where(p => p.PedidoItem.Pedido.IdCliente == idCliente).ToList();
        }

        public IEnumerable<RecebimentoItem> ObterPorIdPedido(int idPedido)
        {
            return Db.RecebimentoItem.Where(p => p.PedidoItem.IdPedido == idPedido).ToList();
        }

        public IEnumerable<RecebimentoItem> ObterPorIdPedidoItem(int idPedidoItem)
        {
            return Db.RecebimentoItem.Where(p => p.PedidoItem.IdPedidoItem == idPedidoItem).ToList();
        }
    }
}