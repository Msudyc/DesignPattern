/*
Name: Strategy

Definition:
Define a family of algorithms, encapsulate each one, and 
make them interchangeable. Strategy lets the algorithm 
vary independently from clients that use it.

Frequency of use: High

Applicability & Examples:
The strategy design pattern splits the behavior (there are 
many behaviors) of a class from the class itself. This has 
some advantages, but the main draw back is that a client 
must understand how the Strategies differ. Since clients get
exposed to implementation issues the strategy design pattern 
should be used only when the variation in behavior is relevant
to them.

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }
}