using System;
using System.Collections.Generic;
using System.Text;
using VerbLoader.Core.Entities;
using VerbLoader.Core.Interfaces;

namespace VerbLoader.Infrastructure.Repositories.InMemory
{
    public class InMemoryPolishVerbRepository : InMemoryVerbWithGermanRepository, IPolishVerbRepository
    {
        public InMemoryPolishVerbRepository(Dictionary<int, VerbWithGerman> store) : base(store)
        {
        }

        PolishVerb IPolishVerbRepository.GetByGerman(string german)
        {
            return (PolishVerb)base.GetByGerman(german);
        }
    }
}
