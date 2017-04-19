using System;
using System.Collections.Generic;
using G2xFoodMaster.Aplicacao.Compra.ViewModel;
using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Enum;

namespace G2xFoodMaster.Aplicacao.Compra
{
    public interface IPedidoApp : IBaseApp<Pedido>
    {
        IEnumerable<PedidoDoClienteViewModel> ObterPorIdCliente(int idCliente,DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido, int take, int skip);
        IEnumerable<PedidoDoClienteViewModel> ObterPorIdFilial(int idFilial, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido, int take, int skip);
        IEnumerable<PedidoDoClienteViewModel> ObterPorIdEstabelecimento(int idEstabelecimento, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido, int take, int skip);
        IEnumerable<PedidoDoClienteViewModel> ObterPorIdFuncionarioEntregador(int idFuncionarioEntregador, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido, int take, int skip);
    }
}