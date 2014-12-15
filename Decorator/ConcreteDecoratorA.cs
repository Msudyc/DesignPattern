namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component)
            : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            this.AddedBehavior();
            Console.WriteLine("ConcreteDecoratorA.Operation");
        }

        private void AddedBehavior()
        {
            Console.WriteLine("ConcreteDecoratorA.AddedBehavior");
        }
    }
}