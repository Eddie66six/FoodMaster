using System;
using System.Collections.Generic;

namespace G2xFoodMaster.Dominio.Compra.Entidade
{
    public class Pedido
    {
        public int IdPedido { get; protected set; }
        public int IdCliente { get; protected set; }
        public virtual Cliente.Entidade.Cliente Cliente { get; protected set; }
        public virtual List<PedidoItem> ItensDoPedido { get; protected set; }
        public int? IdFuncionarioEntregador { get; protected set; }
        public virtual Funcionario.Entidade.Funcionario FuncionarioEntregador { get; protected set; }
        public bool Cancelado { get; protected set; }
        public DateTime? DataDeCancelamento { get; protected set; }
        public int? IdFuncionarioCancelamento { get; protected set; }
        public virtual Funcionario.Entidade.Funcionario FuncionarioCancelamento { get; protected set; }
        public int? IdFuncionarioPedido { get; protected set; }
        public virtual Funcionario.Entidade.Funcionario FuncionarioPedido { get; protected set; }
    }
}