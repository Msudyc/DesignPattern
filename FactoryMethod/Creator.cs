/*
Name: Factory Method

Definition:
Define an interface for creating an object, but let subclasses decide 
which class to instantiate. Factory Method lets a class defer instantiation
to subclasses. 

Frequency of use: High

Applicability & Examples:
If you have many object of the same base type and you manipulate them mostly 
as abstract objects, then you need a factory. It introduces a separation 
between the application and a family of classes (it introduces weak coupling
instead of tight coupling hiding concrete classes from the application). 

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Creator
    {
        public abstract Product CreateProduct();
    }
}