namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator)
            : base(mediator)
        {
        }
        
        public override void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: " + message);
        }
    }
}