namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}