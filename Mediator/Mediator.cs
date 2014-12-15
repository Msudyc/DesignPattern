/*
Name: Mediator

Definition:
Define an object that encapsulates how a set of objects interact.
Mediator promotes loose coupling by keeping objects from referring
to each other explicitly, and it lets you vary their interaction 
independently. 

Frequency of use: Medium low

Applicability & Examples:
Chat application, have a hub where all participants will connect

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Mediator
    {
        public abstract void Register(Colleague colleague);
        public abstract void Send(string message, Colleague colleague);
    }
}