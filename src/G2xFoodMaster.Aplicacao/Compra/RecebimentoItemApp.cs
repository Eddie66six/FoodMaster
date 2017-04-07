using G2xFoodMaster.Aplicacao._Comun;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Interface.Servico;

namespace G2xFoodMaster.Aplicacao.Compra
{
    public class RecebimentoItemApp: BaseApp<RecebimentoItem>, IRecebimentoItemApp
    {
        private readonly IRecebimentoItemServico _recebimentoItemServico;
        public RecebimentoItemApp(IRecebimentoItemServico recebimentoItemServico) : base(recebimentoItemServico)
        {
            _recebimentoItemServico = recebimentoItemServico;
        }
    }
}