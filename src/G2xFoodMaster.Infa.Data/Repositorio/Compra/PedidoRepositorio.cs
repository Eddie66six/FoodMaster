using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Enum;
using G2xFoodMaster.Dominio.Compra.Interface.Repositorio;

namespace G2xFoodMaster.Infa.Data.Repositorio.Compra
{
    public class PedidoRepositorio : _Comun.BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public IEnumerable<Pedido> ObterPorIdCliente(int idCliente, string[] includes, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido)
        {
            var query = Db.Pedido
                .Where(p => p.IdCliente == idCliente)
                .Where(p=>DbFunctions.TruncateTime(p.DataDoPedido) >= DbFunctions.TruncateTime(dataInicio)
                && DbFunctions.TruncateTime(p.DataDoPedido) <= DbFunctions.TruncateTime(dataFim));
            if (statusDoPedido.HasValue)
                query = query.Where(p => p.StatusDoPedido == statusDoPedido);

            query = includes.Aggregate(query, (current, include) => current.Include(include));
            return query.ToList();
        }

        public IEnumerable<Pedido> ObterPorIdEstabelecimento(int idEstabelecimento, string[] includes)
        {
            return Db.Pedido
                .Join(Db.PedidoItem.Where(p=>p.Produto.Filial.IdEstabelecimento == idEstabelecimento),
                    p => p.IdPedido, i => i.IdPedidoItem, (p, i) => new {p, i})
                .Select(p => p.p).ToList();
        }

        public IEnumerable<Pedido> ObterPorIdFilial(int idFilial, string[] includes)
        {
            return Db.Pedido
                .Join(Db.PedidoItem.Where(p => p.Produto.IdFilial == idFilial),
                    p => p.IdPedido, i => i.IdPedidoItem, (p, i) => new { p, i })
                .Select(p => p.p).ToList();
        }

        public IEnumerable<Pedido> ObterPorIdFuncionarioEntregador(int idFuncionarioEntregador, string[] includes)
        {
            return Db.Pedido
                .Where(p=>p.IdFuncionarioEntregador == idFuncionarioEntregador)
                .ToList();
        }
    }
}