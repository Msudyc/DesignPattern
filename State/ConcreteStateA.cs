namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("ConcreteStateA Handled");
            context.State = new ConcreteStateB();
        }
    }
}