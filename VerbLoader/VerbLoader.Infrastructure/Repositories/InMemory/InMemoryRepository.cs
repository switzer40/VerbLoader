using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using VerbLoader.Core.Interfaces;
using VerbLoader.Core.ViewModels;

namespace VerbLoader.Infrastructure.Repositories.InMemory
{
   public class InMemoryRepository<T> : IRepository<T> where T : VerbWithGermanViewModel
    {
        private readonly Dictionary<int, T> _store;
        private static int _nextKey = 1;

        public InMemoryRepository(Dictionary<int, T> store)
        {
            _store = store;
        }
        public T Add(T t)
        {
            throw new NotImplementedException();
        }

        public void Delete(T t)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List(ISpecification<T> specification)
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
