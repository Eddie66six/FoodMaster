using System;
using System.Collections.Generic;
using System.Linq;
using G2xFoodMaster.Aplicacao.Compra.ViewModel;
using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Enum;
using G2xFoodMaster.Dominio.Compra.Interface.Servico;

namespace G2xFoodMaster.Aplicacao.Compra
{
    public class PedidoApp : BaseApp<Pedido>, IPedidoApp
    {
        private readonly IPedidoServico _pedidoServico;
        public PedidoApp(IPedidoServico pedidoServico) : base(pedidoServico)
        {
            _pedidoServico = pedidoServico;
        }

        public IEnumerable<PedidoDoClienteViewModel> ObterPorIdCliente(int idCliente, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido, int take, int skip)
        {
            var includes = new[] { "ItensDoPedido.Produto" };
            var pedido = _pedidoServico.ObterPorIdCliente(idCliente, includes, dataInicio, dataFim, statusDoPedido, take, skip);
            return pedido.Select(p => new PedidoDoClienteViewModel()
            {
                IdDoPedido = p.IdPedido,
                StatusDoPedido = p.StatusDoPedido,
                Titulo = p.ObterTitulosConcatenados(','),
                DataDoPedido = p.DataDoPedido,
                ValorDoPedido = p.ObterValorDaCompra(),
                ValorDesconto = p.ObterValorDeDescontoNaCompra()
            }).ToList();
        }

        public IEnumerable<PedidoDoClienteViewModel> ObterPorIdEstabelecimento(int idEstabelecimento, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido, int take, int skip)
        {
            var includes = new[] { "ItensDoPedido.Produto" };
            var pedido = _pedidoServico.ObterPorIdEstabelecimento(idEstabelecimento, includes, dataInicio, dataFim, statusDoPedido, take, skip);
            return pedido.Select(p => new PedidoDoClienteViewModel()
            {
                IdDoPedido = p.IdPedido,
                StatusDoPedido = p.StatusDoPedido,
                Titulo = p.ObterTitulosConcatenados(','),
                DataDoPedido = p.DataDoPedido,
                ValorDoPedido = p.ObterValorDaCompra(),
                ValorDesconto = p.ObterValorDeDescontoNaCompra()
            }).ToList();
        }

        public IEnumerable<PedidoDoClienteViewModel> ObterPorIdFilial(int idFilial, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido, int take, int skip)
        {
            var includes = new[] { "ItensDoPedido.Produto" };
            var pedido = _pedidoServico.ObterPorIdFilial(idFilial, includes, dataInicio, dataFim, statusDoPedido, take, skip);
            return pedido.Select(p => new PedidoDoClienteViewModel()
            {
                IdDoPedido = p.IdPedido,
                StatusDoPedido = p.StatusDoPedido,
                Titulo = p.ObterTitulosConcatenados(','),
                DataDoPedido = p.DataDoPedido,
                ValorDoPedido = p.ObterValorDaCompra(),
                ValorDesconto = p.ObterValorDeDescontoNaCompra()
            }).ToList();
        }

        public IEnumerable<PedidoDoClienteViewModel> ObterPorIdFuncionarioEntregador(int idFuncionarioEntregador, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido, int take, int skip)
        {
            var includes = new[] { "ItensDoPedido.Produto" };
            var pedido = _pedidoServico.ObterPorIdFuncionarioEntregador(idFuncionarioEntregador, includes, dataInicio, dataFim, statusDoPedido, take, skip);
            return pedido.Select(p => new PedidoDoClienteViewModel()
            {
                IdDoPedido = p.IdPedido,
                StatusDoPedido = p.StatusDoPedido,
                Titulo = p.ObterTitulosConcatenados(','),
                DataDoPedido = p.DataDoPedido,
                ValorDoPedido = p.ObterValorDaCompra(),
                ValorDesconto = p.ObterValorDeDescontoNaCompra()
            }).ToList();
        }
    }
}