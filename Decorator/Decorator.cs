/*
Name: Decorator

Definition:
Attach additional responsibilities to an object dynamically. 
Decorators provide a flexible alternative to subclassing for 
extending functionality. 

Frequency of use: Medium high

Applicability & Examples:
Extending capabilities of a Graphical Window at runtime
Stream, BufferedStream, CryptoStream, GZipStream

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Decorator : Component
    {
        protected Component component;

        public Decorator(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (this.component != null)
            {
                this.component.Operation();
            }
        }
    }
}