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
            PooledObject po1 = Pool.GetObject();
            po1.TempDat = "this is po1 data.";
            PooledObject po2 = Pool.GetObject();
            po1.TempDat = "this is po2 data.";

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            Pool.ReleaseObject(po1);
            Pool.ReleaseObject(po2);
            Console.WriteLine("Now Time: {0}.", DateTime.Now);

            PooledObject po3 = Pool.GetObject();
            Console.WriteLine("Created Time: {0}.", po3.CreateAt);
            Console.ReadLine();
        }
    }
}
