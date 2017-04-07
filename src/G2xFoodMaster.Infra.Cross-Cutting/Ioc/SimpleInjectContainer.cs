using G2xFoodMaster.Aplicacao.Cliente;
using G2xFoodMaster.Aplicacao.Compra;
using G2xFoodMaster.Aplicacao.Estabelecimento;
using G2xFoodMaster.Aplicacao.Funcionario;
using G2xFoodMaster.Aplicacao.Produto;
using G2xFoodMaster.Dominio.Cliente.Interface.Repositorio;
using G2xFoodMaster.Dominio.Cliente.Interface.Servico;
using G2xFoodMaster.Dominio.Compra.Interface.Repositorio;
using G2xFoodMaster.Dominio.Compra.Interface.Servico;
using G2xFoodMaster.Dominio.Estabelecimento.Interface.Repositorio;
using G2xFoodMaster.Dominio.Estabelecimento.Interface.Servico;
using G2xFoodMaster.Dominio.Funcionario.Interface.Repositorio;
using G2xFoodMaster.Dominio.Funcionario.Interface.Servico;
using G2xFoodMaster.Dominio.Produto.Interface.Repositorio;
using G2xFoodMaster.Dominio.Produto.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos.Cliente;
using G2xFoodMaster.Dominio.Servicos.Compra;
using G2xFoodMaster.Dominio.Servicos.Estabelecimento;
using G2xFoodMaster.Dominio.Servicos.Funcionario;
using G2xFoodMaster.Dominio.Servicos.Produto;
using G2xFoodMaster.Infa.Data.Repositorio.Cliente;
using G2xFoodMaster.Infa.Data.Repositorio.Compra;
using G2xFoodMaster.Infa.Data.Repositorio.Estabelecimento;
using G2xFoodMaster.Infa.Data.Repositorio.Funcionario;
using G2xFoodMaster.Infa.Data.Repositorio.Produto;
using SimpleInjector;

namespace G2xFoodMaster.Infra.Cross_Cutting.Ioc
{
    public static class SimpleInjectContainer
    {
        public static Container RegistrarServicos()
        {
            var servico = new Container();

            #region Cliente
            servico.Register<IClienteRepositorio, ClienteRepositorio>();
            servico.Register<IClienteServico, ClienteServico>();
            servico.Register<IClienteApp, ClienteApp>();
            #endregion
            #region Compra
            servico.Register<IPedidoRepositorio, PedidoRepositorio>();
            servico.Register<IPedidoServico, PedidoServico>();
            servico.Register<IPedidoApp, PedidoApp>();
            servico.Register<IPedidoItemRepositorio, PedidoItemRepositorio>();
            servico.Register<IPedidoItemServico, PedidoItemServico>();
            servico.Register<IPedidoItemApp, PedidoItemApp>();
            servico.Register<IRecebimentoItemRepositorio, RecebimentoItemRepositorio>();
            servico.Register<IRecebimentoItemServico, RecebimentoItemServico>();
            servico.Register<IRecebimentoItemApp, RecebimentoItemApp>();
            #endregion
            #region Estabelecimento
            servico.Register<IEstabelecimentoRepositorio, EstabelecimentoRepositorio>();
            servico.Register<IEstabelecimentoServico, EstabelecimentoServico>();
            servico.Register<IEstabelecimentoApp, EstabelecimentoApp>();
            servico.Register<IFilialRepositorio, FilialRepositorio>();
            servico.Register<IFilialServico, FilialServico>();
            servico.Register<IFilialApp, FilialApp>();
            #endregion
            #region Funcionario
            servico.Register<IFuncionarioRepositorio, FuncionarioRepositorio>();
            servico.Register<IFuncionarioServico, FuncionarioServico>();
            servico.Register<IFuncionarioApp, FuncionarioApp>();
            #endregion
            #region Produto
            servico.Register<IProdutoRepositorio, ProdutoRepositorio>();
            servico.Register<IProdutoServico, ProdutoServico>();
            servico.Register<IProdutoApp, ProdutoApp>();
            #endregion

            return servico;
        }
    }
}
