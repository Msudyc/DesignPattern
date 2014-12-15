namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}