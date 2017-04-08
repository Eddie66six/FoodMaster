using System.Collections.Generic;
using G2xFoodMaster.Dominio._Comun.Interface.Repositorio;

namespace G2xFoodMaster.Dominio.Compra.Interface.Repositorio
{
    public interface IPedidoItemRepositorio : IBaseRepositorio<Entidade.PedidoItem>
    {
        IEnumerable<Entidade.PedidoItem> ObterPorIdPedido(int idPedido);
    }
}