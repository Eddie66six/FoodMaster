using System.Collections.Generic;

namespace G2xFoodMaster.Dominio._Comun.Interface.Servico
{
    public interface IBaseServico<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity obj);
        void Remover(int id);
        void Dispose();
    }
}