namespace DesignPattern
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class ConcreteMediator : Mediator
    {
        private List<Colleague> colleagues = new List<Colleague>();

        public override void Register(Colleague colleague)
        {
            if (!this.colleagues.Contains(colleague))
            {
                this.colleagues.Add(colleague);
            }
        }
        
        public override void Send(string message, Colleague colleague)
        {
            foreach (Colleague c in this.colleagues)
            {
                if (colleague != c)
                {
                    c.Notify(message);
                }
            }
        }
    }
}