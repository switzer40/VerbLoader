using System;
using System.Collections.Generic;
using System.Text;
using VerbLoader.Core.SharedKernel;

namespace VerbLoader.Core.Entities
{
    public class PrimitiveVerb : VerbWithGerman
    {        
        public string Imperfective { get; set; }
        public string Perfective { get; set; }
        public bool Reflexive { get; set; }
        public int ConjugationClass { get; set; }
        public string PStem { get; set; }

        public string VStem { get; set; }


        public override void Copy(VerbWithGerman other)
        {
            if (other.GetType() == typeof(PrimitiveVerb))
            {
                PrimitiveVerb that = (PrimitiveVerb)other;
                German = that.German;
                Imperfective = that.Imperfective;
                Perfective = that.Perfective;
                Reflexive = that.Reflexive;
                ConjugationClass = that.ConjugationClass;
                PStem = that.PStem;
                VStem = that.VStem;
            }


        }
    }
}
