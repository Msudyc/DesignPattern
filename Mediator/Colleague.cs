namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
            this.mediator.Register(this);
        }

        public void Send(string message)
        {
            this.mediator.Send(message, this);
        }

        public abstract void Notify(string message);
    }
}