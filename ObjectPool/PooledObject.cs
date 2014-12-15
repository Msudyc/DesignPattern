namespace DesignPattern
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class PooledObject
    {
        private DateTime createAt = DateTime.Now;
        public DateTime CreateAt { get { return this.createAt; } }
        public string TempDat { get; set; }
    }
}