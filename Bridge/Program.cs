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
            Abstraction ab = new RefinedAbstraction();
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            Console.ReadLine();
        }
    }
}
