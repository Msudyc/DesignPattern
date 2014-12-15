/*
Name: Composite

Definition:
Compose objects into tree structures to represent part-whole 
hierarchies. Composite lets clients treat individual objects
and compositions of objects uniformly. 

Frequency of use: Medium high

Applicability & Examples:
Graphics Drawing Editor
Control tree

*/

namespace DesignPattern
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Composite : Component
    {
        private List<Component> components;

        public Composite(string name)
            : base(name)
        {
            this.components = new List<Component>();
        }

        public void Add(Component component)
        {
            this.components.Add(component);
        }

        public void Remove(Component component)
        {
            this.components.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.name);
            // Recursively display child nodes
            foreach (Component component in this.components)
            {
                component.Display(depth + 2);
            }
        }
    }
}