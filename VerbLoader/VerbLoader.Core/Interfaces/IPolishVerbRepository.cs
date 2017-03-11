using System;
using System.Collections.Generic;
using System.Text;
using VerbLoader.Core.Entities;

namespace VerbLoader.Core.Interfaces
{
    public interface IPolishVerbRepository : IRepository<PolishVerb>
    {
        new PolishVerb GetByGerman(string german);
    }
}
