namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}