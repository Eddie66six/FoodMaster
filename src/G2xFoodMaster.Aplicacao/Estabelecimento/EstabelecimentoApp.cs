using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Estabelecimento.Interface.Servico;

namespace G2xFoodMaster.Aplicacao.Estabelecimento
{
    public class EstabelecimentoApp:BaseApp<Dominio.Estabelecimento.Entidade.Estabelecimento>,IEstabelecimentoApp
    {
        private readonly IEstabelecimentoServico _estabelecimentoServico;
        public EstabelecimentoApp(IEstabelecimentoServico estabelecimentoServico) : base(estabelecimentoServico)
        {
            _estabelecimentoServico = estabelecimentoServico;
        }
    }
}