using System.Collections.Generic;
using G2xFoodMaster.Dominio._Comun.Interface.Repositorio;

namespace G2xFoodMaster.Dominio.Compra.Interface.Repositorio
{
    public interface IPedidoRepositorio : IBaseRepositorio<Entidade.Pedido>
    {
        IEnumerable<Entidade.Pedido> ObterPorIdCliente(int idCliente);
        IEnumerable<Entidade.Pedido> ObterPorIdFilial(int idFilial);
        IEnumerable<Entidade.Pedido> ObterPorIdEstabelecimento(int idEstabelecimento);
        IEnumerable<Entidade.Pedido> ObterPorIdFuncionarioEntregador(int idFuncionarioEntregador);
    }
}