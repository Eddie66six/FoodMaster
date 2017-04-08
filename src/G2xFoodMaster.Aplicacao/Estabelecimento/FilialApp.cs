using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Estabelecimento.Entidade;
using G2xFoodMaster.Dominio.Estabelecimento.Interface.Servico;

namespace G2xFoodMaster.Aplicacao.Estabelecimento
{
    public class FilialApp:BaseApp<Filial>,IFilialApp
    {
        private readonly IFilialServico _filialServico;
        public FilialApp(IFilialServico filialServico) : base(filialServico)
        {
            _filialServico = filialServico;
        }
    }
}