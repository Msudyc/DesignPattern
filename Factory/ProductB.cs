namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ProductB : Product
    {
        public override Product CreateProduct()
        {
            return new ProductB();
        }

        public override void Print()
        {
            Console.WriteLine("Print from ProductB instance.");
        }
    }
}