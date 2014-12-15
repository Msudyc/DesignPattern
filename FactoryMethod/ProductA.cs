namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ProductA : Product
    {
        public override void Print()
        {
            Console.WriteLine("Print from ProductA instance.");
        }
    }
}