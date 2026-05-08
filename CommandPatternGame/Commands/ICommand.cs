using System;

namespace CommandPatternGame.Commands  
{
    public interface ICommand   
    {
        void Execute();        
        void Undo();           
    }
}
