namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);
    }
}