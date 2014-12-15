namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}