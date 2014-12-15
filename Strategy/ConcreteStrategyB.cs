namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}