namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
}