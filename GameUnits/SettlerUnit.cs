using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override string GetName(){return "SettlerUnit";}
        public override float Cost {
            get { return 5; }
        }

        public override string ToString()
        {
            return $"SettlerUnit: HP={Health} Cost={Cost.ToString("0.00")}";
        }

        public SettlerUnit() : base(1, 3){}
    }
}