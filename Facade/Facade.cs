/*
Name: Facade

Definition:
Provide a unified interface to a set of interfaces in a subsystem. 
Façade defines a higher-level interface that makes the subsystem 
easier to use.  

Frequency of use: Medium high

Applicability & Examples:
New system

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class Facade
    {
        public SubSystemOne one;
        public SubSystemTwo two;
        public SubSystemThree three;
        public SubSystemFour four;

        public Facade()
        {
            this.one = new SubSystemOne();
            this.two = new SubSystemTwo();
            this.three = new SubSystemThree();
            this.four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine(" Method A");
            this.one.MethodOne();
            this.three.MethodThree();
            this.four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine(" Method B");
            this.two.MethodTwo();
            this.four.MethodFour();
        }
    }
}