using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VerbLoader.Core.Entities;
using VerbLoader.Core.Interfaces;

namespace VerbLoader.Infrastructure.Repositories.InMemory
{
    public class InMemoryVerbWithGermanRepository : InMemoryRepository<VerbWithGerman>, IVerbWithGermanRepository
    {
        public InMemoryVerbWithGermanRepository(Dictionary<int, VerbWithGerman> store) : base(store)
        {
        }

        public VerbWithGerman GetByGerman(string german)
        {

            return List(v => v.German.Contains(german)).Single();

        }
    }
}
