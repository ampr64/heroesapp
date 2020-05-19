using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using HeroesBackend.Common.Pagging;
using HeroesBackend.Entities;

namespace HeroesBackend.Common.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        List<T> GetByCriteria(Func<T, bool> expression);
        T GetOne(int id, params Expression<Func<T, object>>[] navigationProperties);
        PagedListResult<T> GetPaginated(QueryBase<T> query);
        bool Save(T entity);
    }
}