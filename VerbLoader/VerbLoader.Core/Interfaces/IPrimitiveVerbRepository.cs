using System;
using System.Collections.Generic;
using System.Text;
using VerbLoader.Core.ViewModels;

namespace VerbLoader.Core.Interfaces
{
    public interface IPrimitiveVerbRepository : IRepository<PrimitiveVerbViewModel>
    {
        VerbWithGermanViewModel GetWithGerman(string german);
    }
}
