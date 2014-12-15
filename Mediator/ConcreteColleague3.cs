namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteColleague3 : Colleague
    {
        public ConcreteColleague3(Mediator mediator)
            : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Colleague3 gets message: " + message);
        }
    }
}