using System;
using System.Collections.Generic;
using G2xFoodMaster.Dominio.Compra.Enum;
using G2xFoodMaster.Dominio._Comun.Interface.Servico;

namespace G2xFoodMaster.Dominio.Compra.Interface.Servico
{
    public interface IPedidoServico : IBaseServico<Entidade.Pedido>
    {
        IEnumerable<Entidade.Pedido> ObterPorIdCliente(int idCliente, string[] includes, DateTime dataInicio, DateTime dataFim, EStatusDoPedido? statusDoPedido);
        IEnumerable<Entidade.Pedido> ObterPorIdFilial(int idFilial, string[] includes);
        IEnumerable<Entidade.Pedido> ObterPorIdEstabelecimento(int idEstabelecimento, string[] includes);
        IEnumerable<Entidade.Pedido> ObterPorIdFuncionarioEntregador(int idFuncionarioEntregador, string[] includes);
    }
}