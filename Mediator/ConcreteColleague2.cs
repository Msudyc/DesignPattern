namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator)
            : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: " + message);
        }
    }
}