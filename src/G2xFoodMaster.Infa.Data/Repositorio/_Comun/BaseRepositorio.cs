using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using G2xFoodMaster.Dominio._Comun.Interface.Repositorio;

namespace G2xFoodMaster.Infa.Data.Repositorio._Comun
{
    public class BaseRepositorio<TEntity> : IDisposable, IBaseRepositorio<TEntity> where TEntity : class
    {
        protected Configuracao.DataContext Db = new Configuracao.DataContext();

        public TEntity Adicionar(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
            return obj;
        }
        public TEntity ObterPorId(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> ObterTodos()
        {
            return Db.Set<TEntity>().ToList();
        }
        public void Atualizar(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
        public void Remover(int id)
        {
            var obj = ObterPorId(id);
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
