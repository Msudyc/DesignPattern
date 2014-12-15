/*
Name: Prototype

Definition:
Specify the kind of objects to create using a prototypical instance, and
create new objects by copying this prototype. 

Frequency of use: Medium low

Applicability & Examples:
Use Prototype Pattern when a system should be independent of how its products
are created, composed, and represented, and: 
1, Classes to be instantiated are specified at run-time
2, Avoiding the creation of a factory hierarchy is needed
3, It is more convenient to copy an existing instance than to create a new one.

Game wall, door, window, soldiers.

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Prototype
    {
        private string id;
        public Prototype(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return this.id; }
        }

        public abstract Prototype Clone();
    }
}