namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component)
            : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            this.MoreBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation");
        }

        private void MoreBehavior()
        {
            Console.WriteLine("ConcreteDecoratorB.MoreBehavior");
        }
    }
}