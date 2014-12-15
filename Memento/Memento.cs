/*
Name: Memento

Definition:
Without violating encapsulation, capture and externalize an 
object's internal state so that the object can be restored to 
this state later. 

Frequency of use: Low

Applicability & Examples:
Undo and restore operations in most software.
Database transactions

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class Memento
    {
        private string state;        
        public Memento(string state)
        {
            this.state = state;
        }
        
        public string State
        {
            get { return state; }
        }
    }
}