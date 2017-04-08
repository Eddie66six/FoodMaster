using System.Collections.Generic;
using System.Linq;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Interface.Repositorio;

namespace G2xFoodMaster.Infa.Data.Repositorio.Compra
{
    public class PedidoRepositorio : _Comun.BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public IEnumerable<Pedido> ObterPorIdCliente(int idCliente)
        {
            return Db.Pedido.Where(p => p.IdCliente == idCliente).ToList();
        }

        public IEnumerable<Pedido> ObterPorIdEstabelecimento(int idEstabelecimento)
        {
            return Db.Pedido
                .Join(Db.PedidoItem.Where(p=>p.Produto.Filial.IdEstabelecimento == idEstabelecimento),
                    p => p.IdPedido, i => i.IdPedidoItem, (p, i) => new {p, i})
                .Select(p => p.p).ToList();
        }

        public IEnumerable<Pedido> ObterPorIdFilial(int idFilial)
        {
            return Db.Pedido
                .Join(Db.PedidoItem.Where(p => p.Produto.IdFilial == idFilial),
                    p => p.IdPedido, i => i.IdPedidoItem, (p, i) => new { p, i })
                .Select(p => p.p).ToList();
        }

        public IEnumerable<Pedido> ObterPorIdFuncionarioEntregador(int idFuncionarioEntregador)
        {
            return Db.Pedido
                .Where(p=>p.IdFuncionarioEntregador == idFuncionarioEntregador)
                .ToList();
        }
    }
}