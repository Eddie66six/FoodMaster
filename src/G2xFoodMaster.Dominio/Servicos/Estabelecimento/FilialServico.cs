using System.Collections.Generic;
using G2xFoodMaster.Dominio.Estabelecimento.Entidade;
using G2xFoodMaster.Dominio.Estabelecimento.Interface.Repositorio;
using G2xFoodMaster.Dominio.Estabelecimento.Interface.Servico;
using G2xFoodMaster.Dominio.Servicos._Comun;

namespace G2xFoodMaster.Dominio.Servicos.Estabelecimento
{
    public class FilialServico:BaseServico<Filial>,IFilialServico
    {
        private readonly IFilialRepositorio _filialRepositorio;
        public FilialServico(IFilialRepositorio filialRepositorio) : base(filialRepositorio)
        {
            _filialRepositorio = filialRepositorio;
        }

        public IEnumerable<Filial> ObterPorIdEstabelecimento(int idEstabelecimento)
        {
            return _filialRepositorio.ObterPorIdEstabelecimento(idEstabelecimento);
        }

        public IEnumerable<Filial> ObterPorNome(string nome, string cidade)
        {
            return _filialRepositorio.ObterPorNome(nome,cidade);
        }
    }
}