using System.Collections.Generic;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio._Comun.Entidade;

namespace G2xFoodMaster.Dominio.Cliente.Entidade
{
    public class Cliente : Pessoa
    {

        #region attr
        public int IdCliente { get; protected set; }
        public virtual List<Pedido> Pedidos { get; set; }
        #endregion
    }
}
