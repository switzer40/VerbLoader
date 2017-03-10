using System;
using System.Collections.Generic;
using System.Text;

namespace VerbLoader.Core.Entities
{
    public class PolishVerb : PrimitiveVerb
    {
        public string JaP { get; set; }
        public string JaV { get; set; }
        public string TyP { get; set; }
        public string TyV { get; set; }
        public string OnP { get; set; }
        public string OnV { get; set; }
        public string MyP { get; set; }
        public string MyV { get; set; }
        public string WyP { get; set; }
        public string WyV { get; set; }
        public string OniP { get; set; }
        public string OniV { get; set; }
        public override void Copy(VerbWithGerman other)
        {
            base.Copy(other);
            if (other.GetType() == typeof(PolishVerb))
            {
                PolishVerb that = (PolishVerb)other;
                JaP = that.JaP;
                JaV = that.JaV;
                TyP = that.TyP;
                TyV = that.TyV;
                OnP = that.OnP;
                OnV = that.OnV;
                MyP = that.MyP;
                MyV = that.MyV;
                WyP = that.WyP;
                WyV = that.WyV;
                OniP = that.OniP;
                OniV = that.OniV;
            }
        }
    }
    
}
