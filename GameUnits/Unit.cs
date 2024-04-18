namespace GameUnits
{
    public class Unit
    {
        private int movement;
        public int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            if (this.movement == 0)
            {
                Console.WriteLine("This unit hasn't moved!");
            }
            else
            {
                Console.WriteLine($"This unit has moved {this.movement}");
            }
        }
    }
}
