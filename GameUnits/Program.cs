using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit silly = new MilitaryUnit(2,1,2);
            SettlerUnit joe = new SettlerUnit();

            Console.WriteLine($"This unit's health is {silly.Health}.");
            silly.Move();

            Console.WriteLine($"This unit's health is {joe.Health}.");
            joe.Move();
            
            silly.Attack(joe);

            Console.WriteLine($"This unit's health is {silly.Health}.");
            Console.WriteLine($"This unit's health is {joe.Health}.");

        }
    }
}
