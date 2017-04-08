using System;
using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Cliente.Interface.Servico;

namespace G2xFoodMaster.Aplicacao.Cliente
{
    public class ClienteApp : BaseApp<Dominio.Cliente.Entidade.Cliente>, IClienteApp
    {
        private readonly IClienteServico _clienteServico;
        public ClienteApp(IClienteServico clienteServico) : base(clienteServico)
        {
            _clienteServico = clienteServico;
        }

        public bool Logar(string usuario, string senha)
        {
            return _clienteServico.Logar(usuario, senha);
        }
    }
}