using System;
using System.Collections.Generic;
using G2xFoodMaster.Dominio._Comun.Interface.Servico;

namespace G2xFoodMaster.Aplicacao._Comun
{
    public class BaseApp<TEntity> : IDisposable, IBaseApp<TEntity> where TEntity : class
    {
        private readonly IBaseServico<TEntity> _baseServico;

        public BaseApp(IBaseServico<TEntity> baseServico)
        {
            _baseServico = baseServico;
        }

        public void Add(TEntity obj)
        {
            _baseServico.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _baseServico.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _baseServico.GetAll();
        }

        public void Update(TEntity obj)
        {
            _baseServico.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _baseServico.Remove(obj);
        }

        public void Dispose()
        {
            _baseServico.Dispose();
        }
    }
}