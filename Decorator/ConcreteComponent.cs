namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation");
        }
    }
}