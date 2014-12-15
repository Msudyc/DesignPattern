/*
Name: Visitor

Definition:
Represent an operation to be performed on the elements of an object 
structure. Visitor lets you define a new operation without changing 
the classes of the elements on which it operates.  

Frequency of use: Medium low

Applicability & Examples:
The object structure is not likely to be changed but is very probable
to have new operations which have to be added. Since the pattern 
separates the visitor (representing operations, algorithms, behaviors)
from the object structure it's very easy to add new visitors as long 
as the structure remains unchanged.

If a new visitable object is added to the framework structure all the
implemented visitors need to be modified. The separation of visitors 
and visitable is only in one sense: visitors depend of visitable 
objects while visitable are not dependent of visitors.

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA elementA);
        public abstract void VisitConcreteElementB(ConcreteElementB elementB);
    }
}