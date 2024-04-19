using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class DiplomatUnit : XPUnit
    {
        public override float Cost{ get;}

        public DiplomatUnit() : base(6, 1)
        {
            Cost = 7.1f;
            XP = 0;
        }
    }
}