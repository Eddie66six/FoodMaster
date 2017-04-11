using System.Collections.Generic;
using System.Linq;
using G2xFoodMaster.Aplicacao.Estabelecimento.ViewModel;
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

        public IEnumerable<Filial> ObterPorIdEstabelecimento(int idEstabelecimento)
        {
            return _filialServico.ObterPorIdEstabelecimento(idEstabelecimento);
        }

        public IEnumerable<FilialDetalheViewModel> ObterPorNome(string nome, string cidade)
        {
            return _filialServico.ObterPorNome(nome, cidade).Select(p => new FilialDetalheViewModel()
            {
                IdEstabelecimento = p.IdEstabelecimento,
                NomeEstabelecimento = p.Estabelecimento.Nome,
                IdFilial = p.IdFilial,
                NomeFilial = p.Nome,
                Cidade = p.Cidade,
                Bairro = p.Bairro,
                Rua = p.Rua,
                Numero = p.Numero
            }).ToList();
        }
    }
}