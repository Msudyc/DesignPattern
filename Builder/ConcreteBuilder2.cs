namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteBuilder2 : Builder
    {
        public override void BuildPartA()
        {
            this.product.Add("Part X");
        }

        public override void BuildPartB()
        {
            this.product.Add("Part Y");
        }

        public override void BuildPartC()
        {
            this.product.Add("Part Z");
        }
    }
}