namespace DesignPattern
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Product
    {
        private List<string> parts = new List<string>();

        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("......Product parts are......");
            foreach (var p in this.parts)
                Console.WriteLine(p);
        }
    }
}