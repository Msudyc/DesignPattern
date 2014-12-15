namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }
}