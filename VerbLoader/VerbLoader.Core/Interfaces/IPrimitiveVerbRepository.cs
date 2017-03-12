﻿using System;
using System.Collections.Generic;
using System.Text;
using VerbLoader.Core.Entities;
using VerbLoader.Core.ViewModels;

namespace VerbLoader.Core.Interfaces
{
    public interface IPrimitiveVerbRepository : IVerbWithGermanRepository
    {
        new PrimitiveVerb GetByGerman(string german);
    }
}
