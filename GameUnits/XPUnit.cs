using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class XPUnit : Unit
    {
        public int XP {get; protected set;}

        public SettlerUnit(int move, int health) : base(mov, health)
        {
            XP = 0;
        }
    }
}