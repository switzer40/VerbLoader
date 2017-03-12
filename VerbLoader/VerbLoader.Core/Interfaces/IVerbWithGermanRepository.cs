using System;
using System.Collections.Generic;
using System.Text;
using VerbLoader.Core.Entities;

namespace VerbLoader.Core.Interfaces
{
    public interface IVerbWithGermanRepository : IRepository<VerbWithGerman>
    {
        VerbWithGerman GetByGerman(string german);
    }
}
