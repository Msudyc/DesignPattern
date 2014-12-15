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
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA(c);
            ConcreteDecoratorB d2 = new ConcreteDecoratorB(d1);

            d2.Operation();

            Console.ReadLine();
        }
    }
}
