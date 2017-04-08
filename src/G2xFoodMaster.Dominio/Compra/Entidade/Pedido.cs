using System;
using System.Collections.Generic;

namespace G2xFoodMaster.Dominio.Compra.Entidade
{
    public class Pedido
    {
        #region Contruct
        protected Pedido()
        {
            DataDoPedido = DateTime.Now;
        }

        public Pedido(Cliente.Entidade.Cliente cliente)
        {
            Cliente = cliente;
            DataDoPedido = DateTime.Now;
        }
        #endregion

        #region Methods

        public void AdicionarItens(List<PedidoItem> itens, Funcionario.Entidade.Funcionario funcionarioPedido)
        {
            ItensDoPedido = itens;
        }

        public void DefinirEntregador(Funcionario.Entidade.Funcionario funcionarioEntregador)
        {
            FuncionarioEntregador = funcionarioEntregador;
        }
        #endregion

        #region Attr
        public int IdPedido { get; protected set; }
        public DateTime DataDoPedido { get; protected set; }
        public TimeSpan? HoraDaEntrega { get; protected set; }
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
        #endregion
    }
}