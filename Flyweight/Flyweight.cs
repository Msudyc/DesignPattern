/*
Name: Flyweight

Definition:
The intent of this pattern is to use sharing to support 
a large number of objects that have part of their internal
state in common where the other part of state can vary.

The flyweight pattern uses the concepts of intrinsic and extrinsic data.
Intrinsic data is held in the properties of the shared flyweight objects. 
This information is stateless and generally remains unchanged, if any 
change occurs it would be reflected among all of the objects that reference
the flyweight.
Extrinsic data is computed on the fly means at runtime and it is held outside
of a flyweight object. Hence it can be stateful.

Frequency of use: Medium low

Applicability & Examples:
Mobile game soldier (shape intrinsic shared, color extrinsic)
Characters in document, (Char shared, font, size vary)

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }
}