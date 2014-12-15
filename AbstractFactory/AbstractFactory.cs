/*
Name: Abstract Factory

Definition:
Provide an interface for creating families of related or dependent objects
without specifying their concrete classes. 

Frequency of use: High

Applicability & Examples:
We should use the Abstract Factory design pattern when:
1, the system needs to be independent from the way the products it works 
with how they are created.
2, the system is or should be configured to work with multiple families
of products.
3, a family of products is designed to work only all together.
4, the creation of a library of products is needed, for which is relevant
only the interface, not the implementation, too.
 
Pizza Factory Example

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}