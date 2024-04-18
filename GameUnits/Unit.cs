namespace GameUnits
{
    public class Unit
    {
        private int movement;
        public virtual int Health { get; set; }
        public abstract float Cost{ get;}

        public Unit(int movement, int health, float cost)
        {
            this.movement = movement;
            Health = health;
            Cost = cost;
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
