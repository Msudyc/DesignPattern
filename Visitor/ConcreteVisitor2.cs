namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA e)
        {
            Console.WriteLine(
                "{0} visited by {1}", e.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB e)
        {
            Console.WriteLine(
                "{0} visited by {1}", e.GetType().Name, this.GetType().Name);
        }
    }
}