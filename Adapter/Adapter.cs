/*
Name: Adapter

Definition:
Convert the interface of a class into another interface clients expect. 
Adapter lets classes work together that couldn't otherwise because of 
incompatible interfaces. 

Frequency of use: Medium high

Applicability & Examples:
New software

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            this.adaptee.SpecificRequest();
        }
    }
}