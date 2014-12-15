namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ProductB2 : AbstractProductB
    {
        public override void DoPrint()
        {
            Console.WriteLine("Hello from ProductB2");
        }
    }
}