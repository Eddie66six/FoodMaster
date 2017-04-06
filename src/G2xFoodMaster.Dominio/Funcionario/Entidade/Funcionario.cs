using System.Collections.Generic;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Funcionario.Enum;
using G2xFoodMaster.Dominio._Comun.Entidade;

namespace G2xFoodMaster.Dominio.Funcionario.Entidade
{
    public class Funcionario : Pessoa
    {
        #region attr
        public int IdFuncionario { get; protected set; }
        public ETipoFuncionario TipoDeFuncionario { get; protected set; }
        public virtual List<Pedido> PedidosEntregues { get; protected set; }
        public virtual List<Pedido> PedidosCancelados { get; protected set; }
        public virtual List<Pedido> PedidosFeito { get; protected set; }
        public virtual List<Produto.Entidade.Produto> ProdutosCadastrados { get; protected set; }
        public virtual List<Funcionario> FuncionarioCadastrados { get; protected set ;}
        #endregion
    }
}
