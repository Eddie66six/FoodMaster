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

        public TEntity Adicionar(TEntity obj)
        {
            return _baseServico.Adicionar(obj);
        }

        public TEntity ObterPorId(int id)
        {
            return _baseServico.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _baseServico.ObterTodos();
        }

        public void Atualizar(TEntity obj)
        {
            _baseServico.Atualizar(obj);
        }

        public void Remover(int id)
        {
            _baseServico.Remover(id);
        }

        public void Dispose()
        {
            _baseServico.Dispose();
        }
    }
}