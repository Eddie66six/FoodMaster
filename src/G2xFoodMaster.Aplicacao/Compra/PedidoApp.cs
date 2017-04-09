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
    public class PedidoApp:BaseApp<Pedido>,IPedidoApp
    {
        private readonly IPedidoServico _pedidoServico;
        public PedidoApp(IPedidoServico pedidoServico) : base(pedidoServico)
        {
            _pedidoServico = pedidoServico;
        }
        
        public IEnumerable<PedidoDoClienteViewModel> ObterPorIdCliente(int idCliente, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido)
        {
            var includes = new[] { "ItensDoPedido.Produto" };
            var pedido = _pedidoServico.ObterPorIdCliente(idCliente, includes,dataInicio,dataFim,statusDoPedido);
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

        public IEnumerable<Pedido> ObterPorIdEstabelecimento(int idEstabelecimento)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> ObterPorIdFilial(int idFilial)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> ObterPorIdFuncionarioEntregador(int idFuncionarioEntregador)
        {
            throw new NotImplementedException();
        }
    }
}