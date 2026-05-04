using System;
using CommandPatternGame.Commands;
using CommandPatternGame.Core;

namespace CommandPatternGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(); // (crea el jugador  para videojuego)
            InputHandler input = new InputHandler(); // (crea el invoker)

            ICommand moveUp = new MoveCommand(player, "ARRIBA"); // (comando mover)
            ICommand attack = new AttackCommand(player);         // (comando atacar)

            input.ExecuteCommand(moveUp); // (ejecuta movimiento)
            input.ExecuteCommand(attack); // (ejecuta ataque)

            input.Undo(); // (deshace ataque)
            input.Undo(); // (deshace movimiento)

            Console.ReadLine();
        }
    }
}