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
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();
            
            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
            
            Console.ReadLine();
        }
    }
}
