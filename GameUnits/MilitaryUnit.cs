namespace GameUnits
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        private int baseHP;
        public int AttackPower { get; }
        public int XP { get; private set; }
        public override int Health {
            get { return (baseHP + XP); }
        }
        public override float Cost {
            get { return (this.AttackPower + this.XP); }
        }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
            this.baseHP = health;
        }
    }
}
