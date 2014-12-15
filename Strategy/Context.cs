namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class Context
    {
        private Strategy strategy;
        
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        
        public void ContextInterface()
        {
            this.strategy.AlgorithmInterface();
        }
    }
}