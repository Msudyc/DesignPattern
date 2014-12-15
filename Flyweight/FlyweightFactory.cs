namespace DesignPattern
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();

        public FlyweightFactory()
        {
            this.flyweights.Add("X", new ConcreteFlyweight());
            this.flyweights.Add("Y", new ConcreteFlyweight());
            this.flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            if (this.flyweights.ContainsKey(key))
                return this.flyweights[key];

            return null;
        }
    }
}