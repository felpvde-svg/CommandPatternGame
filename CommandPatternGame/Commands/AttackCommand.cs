using System;
using CommandPatternGame.Core;

namespace CommandPatternGame.Commands
{
    public class AttackCommand : ICommand
    {
        private Player player; // (jugador que ejecuta la acción)

        public AttackCommand(Player player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.Attack(); // (le dice al jugador que ataque)
        }

        public void Undo()
        {
            Console.WriteLine("Deshaciendo ataque");
        }
    }
}