using System;
using System.Linq.Expressions;
using VerbLoader.Core.SharedKernel;
using VerbLoader.Core.ViewModels;

namespace VerbLoader.Core.Interfaces
{
    public interface ISpecification<T> where T : VerbWithGermanViewModel
    {
        Expression<Func<T, bool>> Predicate { get; }
    }
}