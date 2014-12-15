namespace DesignPattern
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 10;
            FlyweightFactory factory = new FlyweightFactory();
            // Work with different flyweight instances
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);
            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);
            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);
            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);
            
            Console.ReadLine();
        }
    }
}
