namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver)
            : base(receiver)
        {
        }

        public override void Execute()
        {
            this.receiver.Action();
        }
    }
}