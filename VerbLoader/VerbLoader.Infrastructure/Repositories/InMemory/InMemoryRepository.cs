using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using VerbLoader.Core.Entities;
using VerbLoader.Core.Interfaces;

namespace VerbLoader.Infrastructure.Repositories.InMemory
{
    public class InMemoryRepository<T> : IRepository<T> where T : VerbWithGerman
    {
        private readonly Dictionary<int, T> _store;
        private static int _nextKey = 1;
        public InMemoryRepository(Dictionary<int, T> store)
        {
            _store = store;
            _nextKey = 1;
        }
        public T Add(T t)
        {
            if (t.Id > 0)
            {
                return t;
            }
            else
            {
                t.Id = _nextKey++;
                _store[t.Id] = t;
                return t;
            }
        }

        public void Delete(T t)
        {
            _store.Remove(t.Id);
        }

        public T GetById(int id)
        {
            T result = null;
            if (_store.ContainsKey(id))
            {
                result = _store[id];
            }
            return result;
        }

        public IEnumerable<T> List()
        {
            return _store.Values;
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            Func<T, bool> f = predicate.Compile();
            return List(t => f(t));
        }

        public IEnumerable<T> List(ISpecification<T> specification)
        {
            return List(specification.Predicate);
        }

        public void Update(T t)
        {
            T storedEntity = GetById(t.Id);
            storedEntity.Copy(t);
        }
    }
}
