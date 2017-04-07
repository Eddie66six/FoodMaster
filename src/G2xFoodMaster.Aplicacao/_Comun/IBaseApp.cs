using System.Collections.Generic;

namespace G2xFoodMaster.Aplicacao._Comun
{
    public interface IBaseApp<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}