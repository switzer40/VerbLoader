using System;
using System.Collections.Generic;
using System.Text;
using VerbLoader.Core.Entities;

namespace VerbLoader.Infrastructure.Repositories.InMemory
{
    public class InMemoryPolishVerbRepository : InMemoryVerbWithGermanRepository
    {
        public InMemoryPolishVerbRepository(Dictionary<int, VerbWithGerman> store) : base(store)
        {
        }

        public new PolishVerb GetByGerman(string german)
        {
            return (PolishVerb)base.GetByGerman(german);
        }
    }
}
