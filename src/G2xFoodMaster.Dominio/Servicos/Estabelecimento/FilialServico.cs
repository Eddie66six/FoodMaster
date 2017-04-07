using G2xFoodMaster.Dominio.Estabelecimento.Entidade;
using G2xFoodMaster.Dominio.Estabelecimento.Interface.Repositorio;
using G2xFoodMaster.Dominio.Estabelecimento.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Estabelecimento
{
    public class FilialServico:BaseServico<Filial>,IFilialServico
    {
        private readonly IFilialRepositorio _repositorio;
        public FilialServico(IFilialRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}