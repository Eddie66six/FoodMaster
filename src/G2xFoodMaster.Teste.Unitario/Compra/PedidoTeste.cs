using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using G2xFoodMaster.Dominio.Cliente.Entidade;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Estabelecimento.Entidade;
using G2xFoodMaster.Dominio.Funcionario.Entidade;
using G2xFoodMaster.Dominio.Funcionario.Enum;
using G2xFoodMaster.Dominio.Produto.Entidade;
using G2xFoodMaster.Dominio._Comun.Entidade;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace G2xFoodMaster.Teste.Unitario.Compra
{
    [TestClass]
    public class PedidoTeste
    {

        [TestMethod]
        public void ObterTitulosConcatenados()
        {
           var estabelecimento = new Estabelecimento("G2x");
           var filial = new Filial("G2x-filail 1", estabelecimento);
           var produto = new Produto("123", "pizza", "seila", 30, "", filial);
           var login = new Login("gui", "123");
           var funcionario = new Funcionario(ETipoFuncionario.Gerente, "guilherme", "rodrigues", "gui", "quintais", "18052601", "emiliano ramos", "399", "casa", "sorocaba sp", new DateTime(1991, 05, 23), login, filial);
           var cliente = new Cliente("guilherme", "rodrigues", "gui", "quintais", "18052601", "emiliano ramos", "399", "casa", "sorocaba sp", new DateTime(1991, 05, 23), login, funcionario);
           var pedido = new Pedido(cliente);
            var pedidoItems = new List<PedidoItem>()
            {
                new PedidoItem(0,null,produto),
                new PedidoItem(0,null,produto)
            };
            pedido.AdicionarItens(pedidoItems,funcionario);
            var regex = new Regex(@"\w+(,)\w+\w+");
            var match = regex.Match(pedido.ObterTitulosConcatenados(','));
            if (!match.Success)
            {
                Assert.Fail("erro");
            }
        }

        [TestMethod]
        public void FazerPedido()
        {
            
        }
    }
}
