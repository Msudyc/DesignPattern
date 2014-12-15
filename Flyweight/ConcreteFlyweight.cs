namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteFlyweight : Flyweight
    {
        private string intrinsicState = "Expensive";
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight: {0} {1}", intrinsicState, extrinsicstate);
        }
    }
}