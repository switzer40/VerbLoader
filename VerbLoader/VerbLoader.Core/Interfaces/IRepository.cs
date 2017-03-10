using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using VerbLoader.Core.SharedKernel;

namespace VerbLoader.Core.Interfaces
{
    interface IRepository<T> where T : BaseEntity
    {
        T Add(T t);
        void Delete(T t);
        T GetById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        IEnumerable<T> List(ISpecification<T> specification);
        void Update(T t);
    }
}
