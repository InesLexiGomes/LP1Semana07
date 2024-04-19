using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class DiplomatUnit : XPUnit
    {
        public override string GetName(){return "DiplomatUnit";}
        public override float Cost{ get;}

        public DiplomatUnit() : base(6, 1)
        {
            Cost = 7.1f;
            XP = 0;
        }

        public void MakeAgreement(Unit unit)
        {
            if (unit.GetName() == "DiplomatUnit")
            {
                XP += 3;
            }
            else if (unit.GetName() == "SettlerUnit")
            {
                XP += 2;
            }
            else {XP += 1;}
        }
    }
}