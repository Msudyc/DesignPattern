/*
Name: Object Pool

Definition:
Reuse and share objects that are expensive to create.

Frequency of use: Medium

Applicability & Examples:
Basically, we'll use an object pool whenever there are 
several clients who needs the same stateless resource which
is expensive to create

Sql connections.

*/

namespace DesignPattern
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public static class Pool
    {
        private static List<PooledObject> available = new List<PooledObject>();
        private static List<PooledObject> inUse = new List<PooledObject>();

        public static PooledObject GetObject()
        {
            lock (available)
            {
                if (available.Count > 0)
                {
                    PooledObject po = available[0];
                    inUse.Add(po);
                    available.RemoveAt(0);
                    return po;
                }
                else
                {
                    PooledObject po = new PooledObject();
                    inUse.Add(po);
                    return po;
                }
            }
        }

        public static void ReleaseObject(PooledObject po)
        {
            CleanUp(po);
            lock (available)
            {
                available.Add(po);
                inUse.Remove(po);
            }
        }

        private static void CleanUp(PooledObject po)
        {
            po.TempDat = null;
        }
    }
}