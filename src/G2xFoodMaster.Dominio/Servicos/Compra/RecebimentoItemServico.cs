using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Interface.Repositorio;
using G2xFoodMaster.Dominio.Compra.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Compra
{
    public class RecebimentoItemServico : BaseServico<RecebimentoItem>,IRecebimentoItemServico
    {
        private readonly IRecebimentoItemRepositorio _repositorio;
        public RecebimentoItemServico(IRecebimentoItemRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}