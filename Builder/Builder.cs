/*
Name: Builder

Definition:
Separate the construction of a complex object from its representation so 
that the same construction process can create different representations.

Frequency of use: Medium low

Applicability & Examples:
Complex objects are created in a step-by-step fashion. The construction
process can create different object representations and provides a high 
level of control over the assembly of the objects.

Vehicle Manufacturer, Students Exams.

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Builder
    {
        protected Product product = new Product();
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public Product GetResult()
        {
            return this.product;
        }
    }
}