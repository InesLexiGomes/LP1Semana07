using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class XPUnit : Unit
    {
        public int XP {get; protected set;}
        public override float Cost{ get;}

        public XPUnit(int mov, int health) : base(mov, health)
        {
            Cost = 0;
            XP = 0;
        }
    }
}