using System;
using CommandPatternGame.Core;

namespace CommandPatternGame.Commands
{
    public class MoveCommand : ICommand
    {
        private Player player;     // (jugador que ejecuta la acción)
        private string direction;  // (dirección del movimiento)

        public MoveCommand(Player player, string direction)
        {
            this.player = player;
            this.direction = direction;
        }

        public void Execute()
        {
            player.Move(direction); // (le dice al jugador que se mueva)
        }

        public void Undo()
        {
            Console.WriteLine("Deshaciendo movimiento hacia " + direction);
        }
    }
}