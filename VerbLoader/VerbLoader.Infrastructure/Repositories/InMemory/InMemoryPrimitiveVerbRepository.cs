using System;
using System.Collections.Generic;

using System.Text;
using VerbLoader.Core.Entities;

namespace VerbLoader.Infrastructure.Repositories.InMemory
{
    public class InMemoryPrimitiveVerbRepository : InMemoryVerbWithGermanRepository
    {
        public InMemoryPrimitiveVerbRepository(Dictionary<int, VerbWithGerman> store) : base(store)
        {
        }

        public new PrimitiveVerb GetByGerman(string german)
        {
            return (PrimitiveVerb)base.GetByGerman(german);

        }
    }
}