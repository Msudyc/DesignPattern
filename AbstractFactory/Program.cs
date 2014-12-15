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
            AbstractFactory factory = new Factory1();
            Client client = new Client(factory);
            client.Run();

            factory = new Factory2();
            client = new Client(factory);
            client.Run();

            Console.ReadLine();
        }
    }
}
