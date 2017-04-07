using G2xFoodMaster.Dominio.Cliente.Interface.Repositorio;
using G2xFoodMaster.Dominio.Cliente.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Cliente
{
    public class ClienteServico : BaseServico<Dominio.Cliente.Entidade.Cliente>, IClienteServico
    {
        private readonly IClienteRepositorio _repositorio;
        public ClienteServico(IClienteRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}