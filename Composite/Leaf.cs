namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.name);
        }
    }
}