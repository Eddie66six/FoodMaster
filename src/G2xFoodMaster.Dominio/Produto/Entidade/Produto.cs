using System.Collections.Generic;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio._Comun.Entidade;

namespace G2xFoodMaster.Dominio.Produto.Entidade
{
    public class Produto : Base
    {
        public int IdProduto { get; protected set; }
        public string Codigo { get; protected set; }
        public string Titulo { get; protected set; }
        public string Descricao { get; protected set; }
        public decimal Valor { get; protected set; }
        public string UrlImagem { get; protected set; }
        public virtual List<PedidoItem> PedidoItems { get; set; }
    }
}