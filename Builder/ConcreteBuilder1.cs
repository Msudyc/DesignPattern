namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteBuilder1 : Builder
    {
        public override void BuildPartA()
        {
            this.product.Add("Part A");
        }

        public override void BuildPartB()
        {
            this.product.Add("Part B");
        }

        public override void BuildPartC()
        {
            this.product.Add("Part C");
        }
    }
}