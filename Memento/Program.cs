﻿namespace DesignPattern
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";
            // Store internal state
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            // Continue changing originator
            o.State = "Off";
            // Restore saved state
            o.SetMemento(c.Memento);
            
            Console.ReadLine();
        }
    }
}
