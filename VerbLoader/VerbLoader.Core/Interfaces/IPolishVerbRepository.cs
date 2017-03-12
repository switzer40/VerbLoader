using System;
using System.Collections.Generic;
using System.Text;
using VerbLoader.Core.Entities;

namespace VerbLoader.Core.Interfaces
{
    public interface IPolishVerbRepository : IVerbWithGermanRepository
    {
        new PolishVerb GetByGerman(string gewrman);
    }
}
