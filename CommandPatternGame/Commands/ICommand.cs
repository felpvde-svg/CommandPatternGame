using System;

namespace CommandPatternGame.Commands  // (organiza el código dentro de este paquete)
{
    public interface ICommand   // (contrato: todos los comandos deben cumplir esto)
    {
        void Execute();        // (método que ejecuta la acción del comando)
        void Undo();           // (método que deshace la acción ejecutada)
    }
}