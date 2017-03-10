using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using VerbLoader.Core.Interfaces;
using VerbLoader.Core.ViewModels;

namespace VerbLoader.Infrastructure.Repositories.InMemory
{
    public class InMemoryPrimitiveVerbRepository : InMemoryRepository<PrimitiveVerbViewModel>, IPrimitiveVerbRepository
    {
        public InMemoryPrimitiveVerbRepository(Dictionary<int, PrimitiveVerbViewModel> store) : base(store)
        {
        }

        public VerbWithGermanViewModel GetWithGerman(string german)
        {
            throw new NotImplementedException();
        }
    }
}
