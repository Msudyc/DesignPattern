/*
Name: Chain of Responsibility

Definition:
Avoid coupling the sender of a request to its receiver by giving more 
than one object a chance to handle the request. Chain the receiving objects
and pass the request along the chain until an object handles it.   

Frequency of use: Medium low

Applicability & Examples:
 * More than one object can handle a command
 * The handler is not known in advance
 * The handler should be determined automatically
 * It’s wished that the request is addressed to a group of objects 
   without explicitly specifying its receiver
 * The group of objects that may handle the command must be specified
   in a dynamic way

A system that approves the purchasing requests
A shipping system for electronic orders

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Handler
    {
        protected Handler successor;
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
        
        public abstract void HandleRequest(int request);
    }
}