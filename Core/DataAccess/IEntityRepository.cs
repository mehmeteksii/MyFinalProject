using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generic Constraint 
    //class:  referans tip demek class demek değil
    //IEntity: ya IEntity olabilir ya da IEntity implemente eden bir nesne olabilir 
    //new(): new' lenebilir olmalı
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);//tek bir data getirmek için ör tek kredinin detayları gibi veya tek bir hesabın detayları gibi
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity); 
    }
}
