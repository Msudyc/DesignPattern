/*
Name: Iterator

Definition:
Provide a way to access the elements of an aggregate object
sequentially without exposing its underlying representation.

Frequency of use: High

Applicability & Examples:
foreach

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}