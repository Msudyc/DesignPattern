/*
Name: Observer

Definition:
Define a one-to-many dependency between objects so that when 
one object changes state, all its dependents are notified and 
updated automatically.  

Frequency of use: High

Applicability & Examples:
Model View Controller Pattern
Event management

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Observer
    {
        public abstract void Update();
    }
}