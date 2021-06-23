namespace command.Interfaces
{
    public interface ICommand
    {
        void Call();
        void Undo();
    }   
}