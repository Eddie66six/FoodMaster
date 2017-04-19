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
        private readonly Estabelecimento _estabelecimento;
        private readonly Filial _filial;
        private readonly Produto _produto;
        private readonly Login _login;
        private readonly Funcionario _funcionario;
        private readonly Cliente _cliente;
        private readonly Pedido _pedido;
        private readonly List<PedidoItem> _pedidoItems;
        public PedidoTeste()
        {
            _estabelecimento = new Estabelecimento("G2x");
            _filial = new Filial("G2x-filail 1", _estabelecimento);
            _produto = new Produto("123", "pizza", "seila", 30, "", _filial);
            _login = new Login("gui", "123");
            _funcionario = new Funcionario(ETipoFuncionario.Gerente, "guilherme", "rodrigues", "gui", "quintais", "18052601", "emiliano ramos", "399", "casa", "sorocaba sp", new DateTime(1991, 05, 23), _login, _filial);
            _cliente = new Cliente("guilherme", "rodrigues", "gui", "quintais", "18052601", "emiliano ramos", "399", "casa", "sorocaba sp", new DateTime(1991, 05, 23), _login, _funcionario);
            _pedido = new Pedido(_cliente);
            _pedidoItems = new List<PedidoItem>()
            {
                new PedidoItem(0,null,_produto),
                new PedidoItem(0,null,_produto)
            };
        }
        [TestMethod]
        public void ObterTitulosConcatenados()
        {
            
            _pedido.AdicionarItens(_pedidoItems,_funcionario);
            var regex = new Regex(@"\w+(,)\w+\w+");
            var match = regex.Match(_pedido.ObterTitulosConcatenados(','));
            if (!match.Success)
            {
                Assert.Fail("erro");
            }
        }
    }
}
