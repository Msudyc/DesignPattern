namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class CreatorA : Creator
    {
        public override Product CreateProduct()
        {
            return new ProductA();
        }
    }
}