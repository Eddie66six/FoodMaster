using System.Collections.Generic;

namespace G2xFoodMaster.Dominio._Comun.Interface.Repositorio
{
    public interface IBaseRepositorio<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
