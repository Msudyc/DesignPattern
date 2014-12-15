namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class Originator
    {
        private string state;
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State = " + state);
            }
        }
        
        // Creates memento 
        public Memento CreateMemento()
        {
            return (new Memento(state));
        }
        
        // Restores original state
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }
}