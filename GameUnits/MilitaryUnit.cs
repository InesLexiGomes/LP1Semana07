namespace GameUnits
{
    public class MilitaryUnit : XPUnit // Heranca!!
    {
        private int baseHP;
        public int AttackPower { get; }
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

        public void Attack(Unit u)
        {
            this.XP++;
            u.Health -= this.AttackPower;
        }

        public override string ToString()
        {
            int hp = Health;
            string cost = Cost.ToString("0.00");
            int ap = AttackPower;
            return $"MilitartUnit: HP={hp} Cost={cost} AP={ap} XP={XP}";
        }
    }
}
