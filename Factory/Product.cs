namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Product
    {
        public abstract Product CreateProduct();
        public abstract void Print();
    }
}