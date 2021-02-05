using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoSMN_ModeloDDD.Dominio.Interfacaces
{
    //repositorio base_ so faz crud padrao essa é sua responsabilidade
    //sempre no projeto temos que criar um repositorio base


   public interface IRepositorioBase<TEntity> where TEntity: class
    // metodos generico
    {
     void Add(TEntity obj);
     TEntity GetById(int id);
     IEnumerable<TEntity> GetAll();
     void Update(TEntity obj);
     void Remove(TEntity obj);
     void ObjectDisposedException();
    }

}
