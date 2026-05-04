using System.Collections.Generic;
using CommandPatternGame.Commands;

namespace CommandPatternGame.Core
{
    public class InputHandler
    {
        private Stack<ICommand> history = new Stack<ICommand>();
        // (guarda los comandos ejecutados)

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();   // (ejecuta el comando)
            history.Push(command); // (lo guarda para undo)
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                ICommand command = history.Pop(); // (toma último comando)
                command.Undo(); // (lo deshace)
            }
        }
    }
}