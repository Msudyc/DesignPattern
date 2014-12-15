/*
Name: Interpreter

Definition:
Given a language, define a representation for its grammar along
with an interpreter that uses the representation to interpret
sentences in the language. 

Frequency of use: Medium low

Applicability & Examples:
Roman Numerals Convertor
Rule Validator
This pattern can be applied for parssing light expressions defined
in simple grammars and sometimes in simple rule engines.

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}