namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class Client
    {
        private AbstractProductA productA;
        private AbstractProductB productB;

        public Client(AbstractFactory factory)
        {
            this.productA = factory.CreateProductA();
            this.productB = factory.CreateProductB();
        }

        public void Run()
        {
            this.productA.Print();
            this.productB.DoPrint();
        }
    }
}