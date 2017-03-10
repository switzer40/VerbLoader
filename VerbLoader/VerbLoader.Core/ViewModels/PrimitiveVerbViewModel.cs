using System;
using System.Collections.Generic;
using System.Text;

namespace VerbLoader.Core.ViewModels
{
    public class PrimitiveVerbViewModel : VerbWithGermanViewModel
    {
        public string Imperfective { get; set; }
        public string Perfective { get; set; }
        public bool Reflexive { get; set; }
        public int ConjugationClass { get; set; }
        public string PStem { get; set; }
        public string VStem { get; set; }
    }
}
