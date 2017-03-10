using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using VerbLoader.Core.SharedKernel;
using VerbLoader.Core.ViewModels;

namespace VerbLoader.Core.Interfaces
{
    public interface IRepository<T> where T : VerbWithGermanViewModel
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
