using G2xFoodMaster.Dominio.Cliente.Interface.Repositorio;
using G2xFoodMaster.Dominio.Cliente.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Cliente
{
    public class ClienteServico : BaseServico<Dominio.Cliente.Entidade.Cliente>, IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteServico(IClienteRepositorio clienteRepositorio) : base(clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public bool Logar(string usuario, string senha)
        {
            return _clienteRepositorio.Logar(usuario, senha);
        }
    }
}