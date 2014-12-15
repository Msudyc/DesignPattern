/*
Name: State

Definition:
Allow an object to alter its behavior when its internal state 
changes. The object will appear to change its class

Frequency of use: Medium

Applicability & Examples:


*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}