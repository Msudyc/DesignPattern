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
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            if (s1 == s2)
            {
                Console.WriteLine("s1 and s2 are the same instance.");
            }

            Console.ReadLine();
        }
    }
}
