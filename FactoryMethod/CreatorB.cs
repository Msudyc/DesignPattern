namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class CreatorB : Creator
    {
        public override Product CreateProduct()
        {
            return new ProductB();
        }
    }
}