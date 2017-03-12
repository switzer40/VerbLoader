using System;
using System.Collections.Generic;

using System.Text;
using VerbLoader.Core.Entities;
using VerbLoader.Core.Interfaces;

namespace VerbLoader.Infrastructure.Repositories.InMemory
{
    public class InMemoryPrimitiveVerbRepository : InMemoryVerbWithGermanRepository, IPrimitiveVerbRepository

    {
        public InMemoryPrimitiveVerbRepository(Dictionary<int, VerbWithGerman> store) : base(store)
        {
        }


        PrimitiveVerb IPrimitiveVerbRepository.GetByGerman(string german)
        {
            return (PrimitiveVerb)base.GetByGerman(german);

        }
    }
}
