namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}