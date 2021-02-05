using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Dominio.Core.Interfaces.Repositorios
{
    public interface IRepositosioBase<TEntity> where TEntity: class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
