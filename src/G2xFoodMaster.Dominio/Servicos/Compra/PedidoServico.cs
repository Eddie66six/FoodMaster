using System;
using System.Collections.Generic;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Enum;
using G2xFoodMaster.Dominio.Compra.Interface.Repositorio;
using G2xFoodMaster.Dominio.Compra.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Compra
{
    public class PedidoServico : BaseServico<Pedido>, IPedidoServico
    {
        private readonly IPedidoRepositorio _pedidoRepositorio;
        public PedidoServico(IPedidoRepositorio pedidoRepositorio) : base(pedidoRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;
        }

        public IEnumerable<Pedido> ObterPorIdCliente(int idCliente, string[] includes, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido, int take, int skip)
        {
            return _pedidoRepositorio.ObterPorIdCliente(idCliente, includes, dataInicio, dataFim, statusDoPedido, take, skip);
        }

        public IEnumerable<Pedido> ObterPorIdEstabelecimento(int idEstabelecimento, string[] includes, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido, int take, int skip)
        {
            return _pedidoRepositorio.ObterPorIdEstabelecimento(idEstabelecimento, includes, dataInicio, dataFim, statusDoPedido, take, skip);
        }

        public IEnumerable<Pedido> ObterPorIdFilial(int idFilial, string[] includes, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido, int take, int skip)
        {
            return _pedidoRepositorio.ObterPorIdFilial(idFilial, includes, dataInicio, dataFim, statusDoPedido, take, skip);
        }

        public IEnumerable<Pedido> ObterPorIdFuncionarioEntregador(int idFuncionarioEntregador, string[] includes, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido, int take, int skip)
        {
            return _pedidoRepositorio.ObterPorIdFuncionarioEntregador(idFuncionarioEntregador, includes, dataInicio, dataFim, statusDoPedido, take, skip);
        }
    }
}