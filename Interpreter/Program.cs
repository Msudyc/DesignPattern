namespace DesignPattern
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
            Context context = new Context();
            // Usually a tree
            List<AbstractExpression> list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
            
            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
            
            Console.ReadLine();
        }
    }
}
