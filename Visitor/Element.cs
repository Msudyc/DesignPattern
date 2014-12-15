namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}