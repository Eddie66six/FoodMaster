using System.Collections.Generic;
using G2xFoodMaster.Dominio._Comun.Interface.Repositorio;

namespace G2xFoodMaster.Dominio.Compra.Interface.Repositorio
{
    public interface IRecebimentoItemRepositorio : IBaseRepositorio<Entidade.RecebimentoItem>
    {
        IEnumerable<Entidade.RecebimentoItem> ObterPorIdCliente(int idCliente);
        IEnumerable<Entidade.RecebimentoItem> ObterPorIdPedidoItem(int idPedidoItem);
        IEnumerable<Entidade.RecebimentoItem> ObterPorIdPedido(int idPedido);
    }
}