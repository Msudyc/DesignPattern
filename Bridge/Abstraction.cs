/*
Name: Bridge

Definition:
Decouple an abstraction from its implementation so that the 
two can vary independently. 

Frequency of use: Medium

Applicability & Examples:
Object Persistence API
Graphical User Interface Frameworks

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Abstraction
    {
        protected Implementor implementor;
        public Implementor Implementor
        {
            set { this.implementor = value; }
        }

        public virtual void Operation()
        {
            this.implementor.Operation();
        }
    }
}