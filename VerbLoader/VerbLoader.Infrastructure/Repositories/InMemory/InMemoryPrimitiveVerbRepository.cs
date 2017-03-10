using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using VerbLoader.Core.Entities;
using VerbLoader.Core.Interfaces;
using VerbLoader.Core.ViewModels;

namespace VerbLoader.Infrastructure.Repositories.InMemory
{
    public class InMemoryPrimitiveVerbRepository : InMemoryRepository<PrimitiveVerb>, IPrimitiveVerbRepository
    {
        public InMemoryPrimitiveVerbRepository(Dictionary<int, PrimitiveVerb> store) : base(store)
        {
        }

        public VerbWithGerman GetWithGerman(string german)
        {
            return List(t => t.German.Contains(german)).FirstOrDefault();
        }
    }
}