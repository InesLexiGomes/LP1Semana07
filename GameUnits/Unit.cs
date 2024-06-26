using System;

namespace GameUnits
{
    public abstract class Unit
    {
        public abstract string GetName();
        private int movement;
        public virtual int Health { get; set; }
        public abstract float Cost{ get;}

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public override string ToString()
        {
            return $"Unit: HP={Health} Cost={Cost.ToString("0.00")}";
        }

        public void Move()
        {
            if (this.movement == 0)
            {
                Console.WriteLine("This unit hasn't moved!");
            }
            else
            {
                Console.WriteLine($"This unit has moved {this.movement}.");
            }
        }
    }
}
