namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteStateC : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("ConcreteStateC Handled");
            context.State = new ConcreteStateA();
        }
    }
}