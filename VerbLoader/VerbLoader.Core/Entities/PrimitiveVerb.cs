using System;
using System.Collections.Generic;
using System.Text;
using VerbLoader.Core.SharedKernel;

namespace VerbLoader.Core.Entities
{
    public class PrimitiveVerb : BaseEntity
    {
        public string German { get; set; }
        public string Imperfective { get; set; }
        public string Perfective { get; set; }
        public bool Reflexive { get; set; }
        public int ConjugationClass { get; set; }
        public string PStem { get; set; }
        public string VStem { get; set; }
    }
}
