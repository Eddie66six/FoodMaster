using System.Collections.Generic;
using System.Linq;
using G2xFoodMaster.Dominio.Produto.Interface.Repositorio;

namespace G2xFoodMaster.Infa.Data.Repositorio.Produto
{
    public class ProdutoRepositorio : _Comun.BaseRepositorio<Dominio.Produto.Entidade.Produto>, IProdutoRepositorio
    {
        public IEnumerable<Dominio.Produto.Entidade.Produto> ObterDescricao(int idFilial, string descricao)
        {
            return Db.Produto.Where(p => p.IdFilial == idFilial)
                .Where(p => p.Descricao.Contains(descricao)).ToList();
        }

        public IEnumerable<Dominio.Produto.Entidade.Produto> ObterPorNome(int idFilial, string nome)
        {
            return Db.Produto.Where(p => p.IdFilial == idFilial)
                .Where(p=>p.Titulo.Contains(nome)).ToList();
        }

        public IEnumerable<Dominio.Produto.Entidade.Produto> ObterTodos(int idFilial)
        {
            return Db.Produto.Where(p => p.IdFilial == idFilial).ToList();
        }
    }
}