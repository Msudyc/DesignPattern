namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;
        
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }
        
        public override void Update()
        {
            this.observerState = subject.SubjectState;
            Console.WriteLine(
                "Observer {0}'s new state is {1}",
                this.name, 
                this.observerState);
        }
        
        public ConcreteSubject Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }
    }
}