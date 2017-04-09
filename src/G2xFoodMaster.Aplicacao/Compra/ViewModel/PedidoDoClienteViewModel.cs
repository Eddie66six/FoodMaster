using System;
using G2xFoodMaster.Dominio.Compra.Enum;

namespace G2xFoodMaster.Aplicacao.Compra.ViewModel
{
    public class PedidoDoClienteViewModel
    {
        public int IdDoPedido { get; set; }
        public EStatusDoPedido StatusDoPedido { get; set; }
        public string Titulo { get; set; }
        public decimal ValorDoPedido { get; set; }
        public decimal ValorDesconto { get; set; }
        public DateTime DataDoPedido { get; set; }
    }
}