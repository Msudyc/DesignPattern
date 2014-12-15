namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}