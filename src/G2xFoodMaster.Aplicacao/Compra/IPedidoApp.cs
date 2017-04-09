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
        IEnumerable<PedidoDoClienteViewModel> ObterPorIdCliente(int idCliente,DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido);
        IEnumerable<Pedido> ObterPorIdFilial(int idFilial);
        IEnumerable<Pedido> ObterPorIdEstabelecimento(int idEstabelecimento);
        IEnumerable<Pedido> ObterPorIdFuncionarioEntregador(int idFuncionarioEntregador);
    }
}