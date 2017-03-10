using System;
using System.Linq.Expressions;
using VerbLoader.Core.SharedKernel;

namespace VerbLoader.Core.Interfaces
{
    public interface ISpecification<T> where T : BaseEntity
    {
        Expression<Func<T, bool>> Predicate { get; }
    }
}