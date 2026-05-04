using System;

namespace CommandPatternGame.Core
{
    public class Player
    {
        public void Move(string direction)
        {
            Console.WriteLine("Jugador se mueve hacia " + direction);
        }

        public void Attack()
        {
            Console.WriteLine("Jugador ataca!");
        }
    }
}