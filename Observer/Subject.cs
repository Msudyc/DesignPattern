namespace DesignPattern
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();
        
        public void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }
        
        public void Detach(Observer observer)
        {
            this.observers.Remove(observer);
        }
        
        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }
    }
}