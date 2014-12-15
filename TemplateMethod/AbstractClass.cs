/*
Name: Template Method

Definition:
Define the skeleton of an algorithm in an operation, deferring
some steps to subclasses. Template Method lets subclasses redefine
certain steps of an algorithm without changing the algorithm's structure. 

Frequency of use: Medium

Applicability & Examples:
Application used by a travel agency
Template method is using as an inverted controls structure, from the 
superclass point of view: “Don't call us, we'll call you”. This refers
to the fact that instead of calling the methods from base class in the
subclasses, the methods from subclass are called in the template method
from superclass.

Due to the above fact a special care should be paid to the access 
modifiers: the template method should be implemented only in the base 
class, and the primitive method should be implemented in the subclasses. 
A particular case of the template method is represented by the 
customization hooks.

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class AbstractClass
    {
        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();
        
        // The "Template method"
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("done..");
        }
    }
}