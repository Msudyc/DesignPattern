namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ProductB1 : AbstractProductB
    {
        public override void DoPrint()
        {
            Console.WriteLine("Hello from ProductB1");
        }
    }
}