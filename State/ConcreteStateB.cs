namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("ConcreteStateB Handled");
            context.State = new ConcreteStateC();
        }
    }
}