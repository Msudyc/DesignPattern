namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class Invoker
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            this.command.Execute();
        }
    }
}