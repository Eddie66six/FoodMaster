using G2xFoodMaster.Dominio.Estabelecimento.Interface.Repositorio;
using G2xFoodMaster.Dominio.Estabelecimento.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Estabelecimento
{
    public class EstabelecimentoServico : BaseServico<Dominio.Estabelecimento.Entidade.Estabelecimento>,IEstabelecimentoServico
    {
        private readonly IEstabelecimentoRepositorio _repositorio;
        public EstabelecimentoServico(IEstabelecimentoRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}