namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}