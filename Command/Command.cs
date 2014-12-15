/*
Name: Command

Definition:
Encapsulate a request as an object, thereby letting you 
parameterize clients with different requests, queue or 
log requests, and support undoable operations.   

Frequency of use: Medium high

Applicability & Examples:
Meal order at a restaurant
The waiter (Invoker) takes the order from the customer on his pad. 
The order is then queued and gets to the cook (Receiver) where it 
is processed.

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}