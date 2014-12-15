namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class Context
    {
        private State state;
        public Context(State state)
        {
            this.State = state;
        }
        
        public State State
        {
            get { return this.state; }
            set
            {
                Console.WriteLine("Set State to: " + value.GetType().Name);
                this.state = value;                
            }
        }
        
        public void Request()
        {
            this.state.Handle(this);
        }
    }
}