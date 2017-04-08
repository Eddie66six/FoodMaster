using System;
using System.Collections.Generic;
using G2xFoodMaster.Dominio._Comun.Interface.Repositorio;
using G2xFoodMaster.Dominio._Comun.Interface.Servico;

namespace G2xFoodMaster.Dominio.Servicos._Comun
{
    public class BaseServico<TEntity> : IDisposable, IBaseServico<TEntity> where TEntity : class
    {
        private readonly IBaseRepositorio<TEntity> _repositorio;

        public BaseServico(IBaseRepositorio<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        public TEntity Adicionar(TEntity obj)
        {
            return _repositorio.Adicionar(obj);
        }

        public TEntity ObterPorId(int id)
        {
            return _repositorio.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }

        public void Atualizar(TEntity obj)
        {
            _repositorio.Atualizar(obj);
        }

        public void Remover(int id)
        {
            _repositorio.Remover(id);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }
    }
}