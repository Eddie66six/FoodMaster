using System;
using System.Collections.Generic;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Enum;
using G2xFoodMaster.Dominio.Compra.Interface.Repositorio;
using G2xFoodMaster.Dominio.Compra.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Compra
{
    public class PedidoServico : BaseServico<Dominio.Compra.Entidade.Pedido>, IPedidoServico
    {
        private readonly IPedidoRepositorio _pedidoRepositorio;
        public PedidoServico(IPedidoRepositorio pedidoRepositorio) : base(pedidoRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;
        }

        public IEnumerable<Pedido> ObterPorIdCliente(int idCliente, string[] includes, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido)
        {
            return _pedidoRepositorio.ObterPorIdCliente(idCliente, includes,dataInicio,dataFim,statusDoPedido);
        }

        public IEnumerable<Pedido> ObterPorIdEstabelecimento(int idEstabelecimento, string[] includes)
        {
            return _pedidoRepositorio.ObterPorIdEstabelecimento(idEstabelecimento, includes);
        }

        public IEnumerable<Pedido> ObterPorIdFilial(int idFilial, string[] includes)
        {
            return _pedidoRepositorio.ObterPorIdFilial(idFilial, includes);
        }

        public IEnumerable<Pedido> ObterPorIdFuncionarioEntregador(int idFuncionarioEntregador, string[] includes)
        {
            return _pedidoRepositorio.ObterPorIdFuncionarioEntregador(idFuncionarioEntregador, includes);
        }
    }
}