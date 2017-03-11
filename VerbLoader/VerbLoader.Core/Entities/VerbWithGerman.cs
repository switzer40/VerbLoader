using System;
using System.Collections.Generic;
using System.Text;
using VerbLoader.Core.SharedKernel;

namespace VerbLoader.Core.Entities
{
    public abstract class VerbWithGerman : BaseEntity
    {
        public string German { get; set; }


        public abstract void Copy(VerbWithGerman other);
       

        
    }
}
